using DuplicateScanner.Cmd.UI;
using DuplicateScanner.Cmd.UI.Commands;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DuplicateScanner.Cmd.Extensions
{
    public static class ServiceCollectionextension
    {
        public static void BindFactoryUi(this ServiceCollection collection)
            => collection.AddTransient<Func<UiMode, IUserInterface>>(InterfaceFactory.Implementation);

        public static void BindFactoryUiCommand(this ServiceCollection collection)
            => collection.AddTransient<Func<string, IUiCommand>>(CommandFactory.Implementation);
    }
}