namespace RemoteClientDF
{
    public class DfStringStream : IDfStream
    {
        public string Value { get; private set; }
        public void AddText(ColorValue color, string text)
        {
            Value += text;
        }

        public void BeginBatch()
        {
        }

        public void EndBatch()
        {
        }

        public void Print(string format, params object[] parameters)
        {
            AddText(ColorValue.ColorBlack, string.Format(format, parameters));
        }

        public void Printerr(string format, params object[] parameters)
        {
            AddText(ColorValue.ColorRed, string.Format(format, parameters));
        }
    }
}