namespace DFHack
{
    public interface IDfStream
    {
        void PrintErr(string format, params object[] parameters);
        void Print(string format, params object[] parameters);
        void BeginBatch();
        void EndBatch();
        void AddText(ColorValue color, string text);
    }
}