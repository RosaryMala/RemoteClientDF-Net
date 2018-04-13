namespace RemoteClientDF
{
    public class ColorOstreamProxy : BufferedColorOstream
    {
        protected IDfStream Target;

        //virtual void flush_proxy();

        public ColorOstreamProxy(IDfStream targetIn)
        {
            Target = targetIn;
        }

        public virtual IDfStream ProxyTarget
        {
            get { return Target; }
        }

        public void Decode(dfproto.CoreTextNotification data)
        {
            int cnt = data.fragments.Count;

            if (cnt > 0)
            {
                Target.BeginBatch();

                for (int i = 0; i < cnt; i++)
                {
                    var frag = data.fragments[i];

                    //color_value color = frag.has_color() ? color_value(frag.color()) : COLOR_RESET;
                    Target.AddText(ColorValue.ColorReset, frag.text);
                    //target.printerr(data.fragments[i].text);
                }

                Target.EndBatch();
            }
        }
    }
}