using MFEstrategyMaker.Stores;
using MFEstrategyMaker.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFEstrategyMaker.Commands
{
    public class OpenModalCommand<TViewModel> : CommandBase
        where TViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<TViewModel> _createModal;

        public OpenModalCommand(NavigationStore navigationStore, Func<TViewModel> createModal)
        {
            _navigationStore = navigationStore;
            _createModal = createModal;
        }

        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentModal = _createModal();
        }
    }
}
