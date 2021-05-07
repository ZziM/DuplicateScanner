using System;
using System.Collections.Generic;
using DuplicateScanner.Cmd.Assets.Scanners.Modes;

namespace DuplicateScanner.Cmd.Assets.Scanners
{
    static class ScannerStorage
    {
        private static readonly ScannerMode[] Modes;

        private static readonly Dictionary<ScannerMode, Func<IFileScanner>> Storage = new()
        {
            {
                ScannerMode.MD5,
                () => new Md5Scanner()
            },
            {
                ScannerMode.SHA256,
                () => new Sha256Scanner()
            },
            {
                ScannerMode.Bytes,
                () => new ByteScanner()
            }
        };

        static ScannerStorage()
        {
            Modes = Enum.GetValues<ScannerMode>();
        }

        public static IEnumerable<IFileScanner> GetScanners(ScannerMode selectedMode)
        {
            foreach (var mode in Modes)
            {
                var key = selectedMode & mode;
                if (Storage.TryGetValue(key, out var func))
                    yield return func();
            }
        }
    }
}