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
    public class CTabTabelasViewModel : CTabItemViewModel
    {
        public ICommand NewDBTable { get; }
        public CTabTabelasViewModel(NavigationStore navigationStore)
        {
            TabName = "Tabelas";

            NewDBTable = new OpenModalCommand<AddNewDBTableVM>(navigationStore,
                () => new AddNewDBTableVM(navigationStore));
        }
    }
}
