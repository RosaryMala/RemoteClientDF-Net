using dfproto;
using ProtoBuf;
using System;

namespace DFHack
{
    public class RemoteFunction<TInput> : RemoteFunctionBase
        where TInput : class, IExtensible, new()
    {
        public new TInput MakeIn() { return (TInput)(base.MakeIn()); }
        public new TInput Input
        {
            get
            {
                return (TInput)(base.Input);
            }
            set
            {
                base.Input = value;
            }
        }

        public RemoteFunction() : base(new TInput(), new EmptyMessage()) { }

        public void Execute()
        {
            if (PClient == null)
                throw new NotImplementedException(); 
            Execute<TInput, EmptyMessage>(DefaultOstream, Input);
        }

        public void Execute(TInput input)
        {
            if (PClient == null)
                throw new NotImplementedException();
            base.Execute<TInput, EmptyMessage>(DefaultOstream, input);
        }

        public CommandResult TryExecute()
        {
            if (PClient == null)
                return CommandResult.CrNotImplemented;
            EmptyMessage empty;
            return base.TryExecute(DefaultOstream, Input, out empty);
        }
        public CommandResult TryExecute(IDFStream stream)
        {
            EmptyMessage empty;
            return base.TryExecute(stream, Input, out empty);
        }
        public CommandResult TryExecute(TInput input)
        {
            if (PClient == null)
                return CommandResult.CrNotImplemented;
            else
            {
                EmptyMessage empty;
                return base.TryExecute(DefaultOstream, input, out empty);
            }
        }
        public CommandResult TryExecute(IDFStream stream, TInput input)
        {
            EmptyMessage empty;
            return base.TryExecute(stream, input, out empty);
        }

        /// <summary>
        /// Tries to bind an RPC function, leaving returning null if it fails.
        /// </summary>
        /// <typeparam name="TInput">Protobuf class used as an input</typeparam>
        /// <param name="client">Connection to Dwarf Fortress</param>
        /// <param name="name">Name of the RPC function to bind to</param>
        /// <param name="proto">Name of the protobuf file to use</param>
        /// <returns>Bound remote function on success, otherwise null.</returns>
        public RemoteFunction(RemoteClient client, string name, string proto = ""): base(new TInput(), new EmptyMessage())
        {
            if (!Bind(client, name, proto))
                throw new InvalidOperationException("Cannot bind " + name);
        }

        public static RemoteFunction<TInput> BindNew(RemoteClient client, string name, string proto = "")
        {
            RemoteFunction<TInput> function = new RemoteFunction<TInput>();
            if (function.Bind(client, name, proto))
                return function;
            return null;
        }
    };

    public class RemoteFunction<TInput, TOutput> : RemoteFunctionBase
        where TInput : class, IExtensible, new()
        where TOutput : class, IExtensible, new()
    {
        public new TInput MakeIn() { return (TInput)(base.MakeIn()); }
        public new TInput Input
        {
            get
            {
                return base.Input as TInput;
            }
            set
            {
                base.Input = value;
            }
        }
        public new TOutput MakeOut() { return (TOutput)(base.MakeOut()); }
        public new TOutput Output
        {
            get
            {
                return base.Output as TOutput;
            }
            set
            {
                base.Output = value;
            }
        }

        public RemoteFunction() : base(new TInput(), new TOutput()) { }

        public CommandResult TryExecute()
        {
            if (PClient == null)
                return CommandResult.CrNotImplemented;
            else
            {
                TOutput tempOut;
                CommandResult result = base.TryExecute(DefaultOstream, Input, out tempOut);
                Output = tempOut;
                return result;
            }
        }
        public CommandResult TryExecute(IDFStream stream)
        {
            TOutput tempOut;
            CommandResult result = base.TryExecute(stream, Input, out tempOut);
            Output = tempOut;
            return result;
        }
        public CommandResult TryExecute(TInput input, out TOutput output)
        {
            if (PClient == null)
            {
                output = new TOutput();
                return CommandResult.CrNotImplemented;
            }
            else
            {
                return base.TryExecute(DefaultOstream, input, out output);
            }
        }
        public CommandResult TryExecute(IDFStream stream, TInput input, out TOutput output)
        {
            return base.TryExecute(stream, input, out output);
        }
        public TOutput Execute(TInput input = null)
        {
            TOutput output;
            if (TryExecute(input, out output) == CommandResult.CrOk)
                return output;
            else
                return null;
        }

        /// <summary>
        /// Tries to bind an RPC function, returning null if it fails.
        /// </summary>
        /// <typeparam name="TInput">Protobuf class used as an input</typeparam>
        /// <typeparam name="TOutput">Protobuf class to use as an output</typeparam>
        /// <param name="client">Connection to Dwarf Fortress</param>
        /// <param name="name">Name of the RPC function to bind to</param>
        /// <param name="proto">Name of the protobuf file to use</param>
        /// <returns>Bound remote function on success, otherwise throws an error..</returns>
        public RemoteFunction(RemoteClient client, string name, string proto = "") : base(new TInput(), new TOutput())
        {
            if (!Bind(client, name, proto))
                throw new InvalidOperationException("Cannot bind " + name);
        }

        /// <summary>
        /// Tries to bind an RPC function, returning null if it fails.
        /// </summary>
        /// <typeparam name="TInput">Protobuf class used as an input</typeparam>
        /// <typeparam name="TOutput">Protobuf class to use as an output</typeparam>
        /// <param name="client">Connection to Dwarf Fortress</param>
        /// <param name="name">Name of the RPC function to bind to</param>
        /// <param name="proto">Name of the protobuf file to use</param>
        /// <returns>Bound remote function on success, otherwise null.</returns>
        public static RemoteFunction<TInput, TOutput> BindNew(RemoteClient client, string name, string proto = "")
        {
            RemoteFunction<TInput, TOutput> function = new RemoteFunction<TInput, TOutput>();
            if (function.Bind(client, name, proto))
                return function;
            return null;
        }
    }
}