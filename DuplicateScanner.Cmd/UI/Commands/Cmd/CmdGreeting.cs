using System;

namespace DuplicateScanner.Cmd.UI.Commands.Cmd
{
    internal class CmdGreeting : IUiCommand
    {
        private readonly IServiceProvider _provider;

        public CmdGreeting(IServiceProvider provider)
        {
            _provider = provider;
        }

        public void Execute()
        {
            Console.WriteLine("-----------------------DUPLICATE SCANNER-----------------------");
        }
    }
}