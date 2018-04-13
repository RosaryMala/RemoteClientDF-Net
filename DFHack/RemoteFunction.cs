using dfproto;
using ProtoBuf;

namespace RemoteClientDF
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

        public CommandResult Execute()
        {
            if (PClient == null)
                return CommandResult.CrNotImplemented;
            EmptyMessage empty;
            return base.Execute(DefaultOstream, Input, out empty);
        }
        public CommandResult Execute(IDfStream stream)
        {
            EmptyMessage empty;
            return base.Execute(stream, Input, out empty);
        }
        public CommandResult Execute(TInput input)
        {
            if (PClient == null)
                return CommandResult.CrNotImplemented;
            else
            {
                EmptyMessage empty;
                return base.Execute(DefaultOstream, input, out empty);
            }
        }
        public CommandResult Execute(IDfStream stream, TInput input)
        {
            EmptyMessage empty;
            return base.Execute(stream, input, out empty);
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

        public CommandResult Execute()
        {
            if (PClient == null)
                return CommandResult.CrNotImplemented;
            else
            {
                TOutput tempOut;
                CommandResult result = base.Execute(DefaultOstream, Input, out tempOut);
                Output = tempOut;
                return result;
            }
        }
        public CommandResult Execute(IDfStream stream)
        {
            TOutput tempOut;
            CommandResult result = base.Execute(stream, Input, out tempOut);
            Output = tempOut;
            return result;
        }
        public CommandResult Execute(TInput input, out TOutput output)
        {
            if (PClient == null)
            {
                output = new TOutput();
                return CommandResult.CrNotImplemented;
            }
            else
            {
                return base.Execute(DefaultOstream, input, out output);
            }
        }
        public CommandResult Execute(IDfStream stream, TInput input, out TOutput output)
        {
            return base.Execute(stream, input, out output);
        }
    }
}