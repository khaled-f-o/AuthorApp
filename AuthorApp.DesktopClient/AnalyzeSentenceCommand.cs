using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace AuthorApp.DesktopClient
{
    public class AnalyzeSentenceCommand : ICommand
    {
        Action _executeMethod;

        public AnalyzeSentenceCommand(Action executeAction)
        {
            _executeMethod = executeAction;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _executeMethod.Invoke();
        }
    }
}
