using dfproto;
using ProtoBuf;

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
    }
}