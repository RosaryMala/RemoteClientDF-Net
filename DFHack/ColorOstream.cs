using AT.MIN;
using UnityEngine;

namespace RemoteClientDF
{
    public class ColorOstream : IDfStream
    {
        private string _buffer;
        public void Printerr(string format, params object[] parameters)
        {
            Debug.LogError(Tools.Sprintf(format, parameters).TrimEnd('\r', '\n'));
        }
        public void Print(string format, params object[] parameters)
        {
            Debug.Log(Tools.Sprintf(format, parameters).TrimEnd('\r', '\n'));
        }
        public void BeginBatch()
        {
            _buffer = "";
        }
        public void EndBatch()
        {
            Debug.Log(_buffer.TrimEnd('\r', '\n'));
            _buffer = null;
        }

        public void AddText(ColorValue color, string text)
        {
            _buffer += text;
        }

    }
}