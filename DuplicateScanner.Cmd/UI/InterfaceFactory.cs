using DuplicateScanner.Cmd.UI.Interfaces;
using System;
using System.Collections.Generic;

namespace DuplicateScanner.Cmd.UI
{
    internal static class InterfaceFactory
    {
        public static readonly Dictionary<UiMode, Func<IServiceProvider, IUserInterface>> Storage = new()
        {
            {
                UiMode.Cmd,
                (provider) => new CmdInterface(provider)
            }
        };

        public static Func<UiMode, IUserInterface> Implementation(IServiceProvider provider)
        {
            return mode =>
            {
                if (Storage.TryGetValue(mode, out var func))
                    return func(provider);
                return null;
            };
        }
    }
}