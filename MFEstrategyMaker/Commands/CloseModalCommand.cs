using MFEstrategyMaker.Stores;
using MFEstrategyMaker.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFEstrategyMaker.Commands
{
    public class CloseModalCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public CloseModalCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }
        public override void Execute(object? parameter)
        {
           _navigationStore.CloseModal();
        }
    }
}
