using MFEstrategyMaker.Stores.RegistersStore;
using MFEstrategyMaker.ViewModels.RegisterViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFEstrategyMaker.Commands.RegistersCommands
{
    public class NewTabCommand<TViewModel> : CommandBase
        where TViewModel : CTabItemViewModel
    {
        private readonly CTabControlStore _cTabControlStore;
        private readonly Func<TViewModel> _createTab;

        public NewTabCommand(CTabControlStore cTabControlStore, Func<TViewModel> createTab)
        {
            _cTabControlStore = cTabControlStore;
            _createTab = createTab;
        }
        public override void Execute(object? parameter)
        {
            _cTabControlStore.AddNewTab(_createTab());
        }
    }
}
