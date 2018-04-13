namespace RemoteClientDF
{
    public interface IDfStream
    {
        void Printerr(string format, params object[] parameters);
        void Print(string format, params object[] parameters);
        void BeginBatch();
        void EndBatch();
        void AddText(ColorValue color, string text);
    }
}