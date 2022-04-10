
using System.Windows.Input;

namespace Explorer.Shared.ViewModels
{
    internal class CommandDelegate : ICommand
    {
        private Action<object> _openDir;

        public CommandDelegate(Action<object> openDir)
        {
            this._openDir = openDir;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _openDir.Invoke(parameter);  
        }
    }
}