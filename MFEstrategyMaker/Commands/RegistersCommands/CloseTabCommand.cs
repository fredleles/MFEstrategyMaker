using MFEstrategyMaker.Stores.RegistersStore;
using MFEstrategyMaker.ViewModels.RegisterViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFEstrategyMaker.Commands.RegistersCommands
{
    public class CloseTabCommand<TViewModel> : CommandBase
        where TViewModel : CTabItemViewModel
    {
        private readonly CTabControlStore _cTabControlStore;
        private readonly CTabItemViewModel _removeTab;

        public CloseTabCommand(CTabControlStore cTabControlStore, CTabItemViewModel removeTab)
        {
            _cTabControlStore = cTabControlStore;
            _removeTab = removeTab;
        }
        public override void Execute(object? parameter)
        {
            _cTabControlStore.CloseTab(_removeTab);
        }
    }
}
