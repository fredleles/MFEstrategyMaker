using MFEstrategyMaker.Commands;
using MFEstrategyMaker.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MFEstrategyMaker.ViewModels.RegisterViewModel
{
    internal class AddNewDBTableVM : ViewModelBase
    {
        public ICommand CloseModalCommand { get; }

        public AddNewDBTableVM(NavigationStore navigationStore)
        {
            CloseModalCommand = new CloseModalCommand(navigationStore);
        }
    }
}
