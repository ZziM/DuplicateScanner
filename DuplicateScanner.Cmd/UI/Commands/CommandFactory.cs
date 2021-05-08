using DuplicateScanner.Cmd.UI.Commands.Cmd;
using System;
using System.Collections.Generic;

namespace DuplicateScanner.Cmd.UI.Commands
{
    internal static class CommandFactory
    {
        private static readonly Dictionary<string, Func<IServiceProvider, IUiCommand>> Storage = new()
        {
            {
                "greeting",
                (provider) => new CmdGreeting(provider)
            }
        };

        public static Func<string, IUiCommand> Implementation(IServiceProvider provider)
        {
            return (key) =>
            {
                if (Storage.TryGetValue(key, out var func))
                    return func(provider);
                return null;
            };
        }
    }
}