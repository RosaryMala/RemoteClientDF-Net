using System;
using ProtoBuf;

namespace RemoteClientDF
{
    public class RpcFunctionBase
    {

        public IExtensible PInTemplate;
        public IExtensible POutTemplate;

        public IExtensible MakeIn()
        {
            return (IExtensible)Activator.CreateInstance(PInTemplate.GetType());
        }

        public IExtensible Input
        {
            get { return _pIn ?? (_pIn = MakeIn()); }
            set
            {
                _pIn = value;
            }
        }

        public IExtensible MakeOut()
        {
            return (IExtensible)Activator.CreateInstance(POutTemplate.GetType());
        }

        public IExtensible Output
        {
            get { return _pOut ?? (_pOut = MakeOut()); }
            set
            {
                _pOut = value;
            }
        }

        public void Reset(bool free = false)
        {
            if (free)
            {
                _pIn = null;
                _pOut = null;
            }
            else
            {
                if (_pIn != null)
                    _pIn = (IExtensible)Activator.CreateInstance(_pIn.GetType());
                if (_pOut != null)
                    _pOut = (IExtensible)Activator.CreateInstance(_pOut.GetType());
            }
        }

        public RpcFunctionBase(IExtensible input, IExtensible output)
        {
            PInTemplate = input;
            POutTemplate = output;
            _pIn = null;
            _pOut = null;
        }

        IExtensible _pIn;
        IExtensible _pOut;
    }
}