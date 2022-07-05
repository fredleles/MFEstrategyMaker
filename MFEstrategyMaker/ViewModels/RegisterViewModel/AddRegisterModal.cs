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
    public class AddRegisterModal : ViewModelBase
    {
        public ICommand CloseModalCommand { get; }

        public AddRegisterModal(NavigationStore navigationStore)
        {
            CloseModalCommand = new CloseModalCommand(navigationStore);
        }
    }
}
