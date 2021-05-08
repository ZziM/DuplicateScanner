using DuplicateScanner.Cmd.UI.Commands;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DuplicateScanner.Cmd.UI.Interfaces
{
    class CmdInterface : IUserInterface
    {
        private readonly IServiceProvider _provider;

        public CmdInterface(IServiceProvider provider)
        {
            _provider = provider;
        }
        public void Execute(string operation)
        {
            var factory = _provider.GetService<Func<string, IUiCommand>>();
            var command = factory(operation);
            command.Execute();
        }
    }
}