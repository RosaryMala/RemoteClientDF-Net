using AT.MIN;
using System;

namespace DFHack
{
    /// <summary>
    /// Basic functionality of IDFStream, with no extras.
    /// </summary>
    public class ConsoleDFStream : IDFStream
    {
        string buffer = "";

        public void AddText(ColorValue color, string text)
        {
            buffer += text;
        }

        public void BeginBatch()
        {
            buffer = "";
        }

        public void EndBatch()
        {
            Console.WriteLine(buffer.TrimEnd('\r', '\n'));
        }

        public void Print(string format, params object[] parameters)
        {
            Console.WriteLine(Tools.Sprintf(format, parameters).TrimEnd('\r', '\n'));
        }

        public void PrintErr(string format, params object[] parameters)
        {
            Console.WriteLine(Tools.Sprintf(format, parameters).TrimEnd('\r', '\n'));
        }
    }
}