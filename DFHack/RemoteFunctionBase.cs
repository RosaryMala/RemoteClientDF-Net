using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using dfproto;
using ProtoBuf;

namespace DFHack
{
    public class RemoteFunctionBase : RPCFunctionBase
    {
        public bool Bind(RemoteClient client, string name,
            string proto = "")
        {
            return Bind(client.DefaultOutput, client, name, proto);
        }
        public bool Bind(IDFStream output,
            RemoteClient client, string name,
            string proto = "")
        {
            if (IsValid())
            {
                if (PClient == client && Name == name && Proto == proto)
                    return true;

                output.PrintErr("Function already bound to %s::%s\n",
                    Proto, Name);
                return false;
            }

            Name = name;
            Proto = proto;
            PClient = client;

            return client.Bind(output, this, name, proto);
        }

        public bool IsValid() { return (Id >= 0); }

        public RemoteFunctionBase(IExtensible input, IExtensible output)
            : base(input, output)
        {
            PClient = null;
            Id = -1;
        }

        protected IDFStream DefaultOstream
        {
            get { return PClient.DefaultOutput; }
        }

        bool SendRemoteMessage(Socket socket, Int16 id, MemoryStream msg)
        {
            var buffer = new List<byte>();

            RpcMessageHeader header = new RpcMessageHeader
            {
                Id = id,
                Size = (Int32) msg.Length
            };
            buffer.AddRange(header.ConvertToBtyes());
            buffer.AddRange(msg.ToArray());

            int fullsz = buffer.Count;
            int got = socket.Send(buffer.ToArray());
            return (got == fullsz);
        }

        protected TOutput Execute<TInput, TOutput>(IDFStream stream, TInput input)
            where TInput : class, IExtensible, new()
            where TOutput : class, IExtensible, new()
        {
            TOutput value;
            var result = TryExecute(stream, input, out value);
            if (result == CommandResult.CrOk)
                return value;
            else
                throw new InvalidOperationException("Remotefunction encountered error: " + value);
        }

        protected CommandResult TryExecute<TInput, TOutput>(IDFStream outString, TInput input, out TOutput output)
            where TInput : class, IExtensible, new()
            where TOutput : class, IExtensible, new()
        {
            if (!IsValid())
            {
                outString.PrintErr("Calling an unbound RPC function %s::%s.\n",
                    Proto, Name);
                output = default(TOutput);
                return CommandResult.CrNotImplemented;
            }

            if (PClient.Socket == null)
            {
                outString.PrintErr("In call to %s::%s: invalid socket.\n",
                    Proto, Name);
                output = default(TOutput);
                return CommandResult.CrLinkFailure;
            }

            MemoryStream sendStream = new MemoryStream();

            Serializer.Serialize(sendStream, input);

            long sendSize = sendStream.Length;

            if (sendSize > RpcMessageHeader.MaxMessageSize)
            {
                outString.PrintErr("In call to %s::%s: message too large: %d.\n",
                    Proto, Name, sendSize);
                output = default(TOutput);
                return CommandResult.CrLinkFailure;
            }

            if (!SendRemoteMessage(PClient.Socket, Id, sendStream))
            {
                outString.PrintErr("In call to %s::%s: I/O error in send.\n",
                    Proto, Name);
                output = default(TOutput);
                return CommandResult.CrLinkFailure;
            }

            ColorOstreamProxy textDecoder = new ColorOstreamProxy(outString);

            //output = new Output();
            //return command_result.CR_OK;

            while (true)
            {
                RpcMessageHeader header = new RpcMessageHeader();
                byte[] buffer = new byte[8];

                if (!RemoteClient.ReadFullBuffer(PClient.Socket, buffer, 8))
                {
                    outString.PrintErr("In call to %s::%s: I/O error in receive header.\n",
                        Proto, Name);
                    output = default(TOutput);
                    return CommandResult.CrLinkFailure;
                }

                header.Id = BitConverter.ToInt16(buffer, 0);
                header.Size = BitConverter.ToInt32(buffer, 4); //because something, somewhere, is fucking retarded

                //outString.print("Received %d:%d.\n", header.id, header.size);


                if ((DfHackReplyCode)header.Id == DfHackReplyCode.RpcReplyFail)
                {
                    output = default(TOutput);
                    if (header.Size == (int)CommandResult.CrOk)
                        return CommandResult.CrFailure;
                    else
                        return (CommandResult)header.Size;
                }

                if (header.Size < 0 || header.Size > RpcMessageHeader.MaxMessageSize)
                {
                    outString.PrintErr("In call to %s::%s: invalid received size %d.\n",
                        Proto, Name, header.Size);
                    output = default(TOutput);
                    return CommandResult.CrLinkFailure;
                }

                byte[] buf = new byte[header.Size];
                if (!RemoteClient.ReadFullBuffer(PClient.Socket, buf, header.Size))
                {
                    outString.PrintErr("In call to %s::%s: I/O error in receive %d bytes of data.\n",
                        Proto, Name, header.Size);
                    output = default(TOutput);
                    return CommandResult.CrLinkFailure;
                }

                switch ((DfHackReplyCode)header.Id)
                {
                    case DfHackReplyCode.RpcReplyResult:
                        output = Serializer.Deserialize<TOutput>(new MemoryStream(buf));
                        if (output != null) return CommandResult.CrOk;
                        outString.PrintErr("In call to %s::%s: error parsing received result.\n",
                            Proto, Name);
                        return CommandResult.CrLinkFailure;

                    case DfHackReplyCode.RpcReplyText:
                        var textData = Serializer.Deserialize<CoreTextNotification>(new MemoryStream(buf));

                        if (textData != null)
                        {
                            textDecoder.Decode(textData);
                        }
                        else
                            outString.PrintErr("In call to %s::%s: received invalid text data.\n",
                                Proto, Name);
                        break;
                }
            }
        }


        public string Name, Proto;
        public RemoteClient PClient;
        public Int16 Id;
    }
}