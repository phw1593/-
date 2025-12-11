using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OAManage.Command
{
    public class DoCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private Action _myAction;

        public DoCommand(Action action)
        {
           this._myAction = action;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _myAction?.Invoke();
        }
    }
}
