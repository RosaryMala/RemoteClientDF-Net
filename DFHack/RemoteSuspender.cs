namespace DFHack
{
    internal class RemoteSuspender
    {
        private readonly RemoteClient _client;
        public RemoteSuspender(RemoteClient clientIn)
        {
            _client = clientIn;
            if (_client == null || _client.SuspendGame() <= 0) _client = null;
        }
        ~RemoteSuspender()
        {
            if (_client != null) _client.ResumeGame();
        }
    };
}