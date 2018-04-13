namespace DFHack
{
    public enum CommandResult
    {
        CrLinkFailure = -3,    // RPC call failed due to I/O or protocol error
        CrNeedsConsole = -2,   // Attempt to call interactive command without console
        CrNotImplemented = -1, // Command not implemented, or plugin not loaded
        CrOk = 0,               // Success
        CrFailure = 1,          // Failure
        CrWrongUsage = 2,      // Wrong arguments or ui state
        CrNotFound = 3         // Target object not found (for RPC mainly)
    }
}