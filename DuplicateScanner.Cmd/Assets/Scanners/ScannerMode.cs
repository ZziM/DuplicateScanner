using System;

namespace DuplicateScanner.Cmd.Assets.Scanners
{
    [Flags]
    enum ScannerMode
    {
        None = 0,
        SHA256 = 1,
        MD5 = 2,
        Bytes = 4
    }
}