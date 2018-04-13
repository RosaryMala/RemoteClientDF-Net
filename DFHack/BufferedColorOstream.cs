namespace RemoteClientDF
{
    public class BufferedColorOstream : ColorOstream
    {
        //protected:
        public new void AddText(ColorValue color, string text)
        {
            if (text.Length == 0)
                return;

            if (Buffer.Length == 0)
            {
                Buffer = text;
            }
            else
            {
                Buffer += text;
            }
        }



        //    buffered_color_ostream() {}
        //    ~buffered_color_ostream() {}

        //    const std::list<fragment_type> &fragments() { return buffer; }

        protected string Buffer;
    }
}