using DuplicateScanner.Cmd.Extensions;
using DuplicateScanner.Cmd.UI;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DuplicateScanner.Cmd
{
    internal class Program
    {
        private static IServiceProvider Provider { get; }

        private static IUserInterface UserInterface { get; }
        
        static Program()
        {
            var collection = new ServiceCollection();

            collection.BindFactoryUi();
            collection.BindFactoryUiCommand();

            Provider = collection.BuildServiceProvider();

            var uiFactory = Provider.GetService<Func<UiMode, IUserInterface>>();

            UserInterface = uiFactory(UiMode.Cmd);
        }

        private static void Main(string[] args)
        {
            UserInterface.Execute("greeting");
        }
    }
}