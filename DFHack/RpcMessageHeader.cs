using System;
using System.Collections.Generic;

namespace DFHack
{
    internal struct RpcMessageHeader
    {
        public const int MaxMessageSize = 64 * 1048576;

        public short Id;
        public int Size;

        public byte[] ConvertToBtyes()
        {
            List<byte> output = new List<byte>();
            output.AddRange(BitConverter.GetBytes(Id));
            output.AddRange(new byte[2]);
            output.AddRange(BitConverter.GetBytes(Size));
            return output.ToArray();
        }
        string BytesToString(byte[] input)
        {
            string output = "";
            foreach (byte item in input)
            {
                if (output.Length > 0)
                    output += ",";
                output += item;
            }
            return output;
        }
    }
}