namespace DFHack
{
    internal class RpcHandshakeHeader
    {
        //public string magic;
        //public int version;

        public static string RequestMagic = "DFHack?\n";
        public static string ResponseMagic = "DFHack!\n";
    }
}