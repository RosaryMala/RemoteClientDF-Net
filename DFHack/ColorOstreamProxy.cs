namespace DFHack
{
    internal class ColorOstreamProxy : IDFStream
    {
        public IDFStream ProxyTarget { get; private set; }

        public ColorOstreamProxy(IDFStream targetIn)
        {
            ProxyTarget = targetIn;
        }

        public void Decode(dfproto.CoreTextNotification data)
        {
            if (data.fragments.Count == 0)
                return;

            foreach (var fragment in data.fragments)
            {
                if (fragment.color != dfproto.CoreTextFragment.Color.COLOR_BLACK)
                    ProxyTarget.AddText((ColorValue)fragment.color, fragment.text);
                else
                    ProxyTarget.AddText(ColorValue.ColorReset, fragment.text);
            }

            ProxyTarget.EndBatch();
        }

        public void PrintErr(string format, params object[] parameters)
        {
            ProxyTarget.PrintErr(format, parameters);
        }

        public void Print(string format, params object[] parameters)
        {
            ProxyTarget.Print(format, parameters);
        }

        public void BeginBatch()
        {
            ProxyTarget.BeginBatch();
        }

        public void EndBatch()
        {
            ProxyTarget.EndBatch();
        }

        public void AddText(ColorValue color, string text)
        {
            ProxyTarget.AddText(color, text);
        }
    }
}