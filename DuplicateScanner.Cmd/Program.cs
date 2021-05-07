using DuplicateScanner.Cmd.UI;

namespace DuplicateScanner.Cmd
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var ui = InterfaceStorage.GetUi(UiMode.Cmd);
        }
    }
}