using DuplicateScanner.Cmd.UI.Interfaces;
using System;
using System.Collections.Generic;

namespace DuplicateScanner.Cmd.UI
{
    internal static class InterfaceStorage
    {
        public static readonly Dictionary<UiMode, Func<IUserInterface>> Storage = new()
        {
            {
                UiMode.Cmd,
                () => new CmdInterface()
            }
        };

        public static IUserInterface GetUi(UiMode uiMode)
        {
            if (Storage.TryGetValue(uiMode, out var func))
                return func();
            return null;
        }
    }
}