using MFEstrategyMaker.Commands;
using MFEstrategyMaker.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MFEstrategyMaker.ViewModels.RegisterViewModel
{
    public class CTabTabelasViewModel : CTabItemViewModel
    {
        public ICommand NewDBTable { get; }
        private readonly ObservableCollection<DbTableNamesListCompVM> _dbTableNamesListCompVM;
        public IEnumerable<DbTableNamesListCompVM> DbTableNamesListCompVM => _dbTableNamesListCompVM;
        public CTabTabelasViewModel(NavigationStore navigationStore)
        {
            TabName = "Tabelas";

            NewDBTable = new OpenModalCommand<AddNewDBTableVM>(navigationStore,
                () => new AddNewDBTableVM(navigationStore));

            _dbTableNamesListCompVM = new ObservableCollection<DbTableNamesListCompVM>();

            _dbTableNamesListCompVM.Add(new DbTableNamesListCompVM("Constantes"));
            _dbTableNamesListCompVM.Add(new DbTableNamesListCompVM("Reuniões_COPOM"));
        }
    }
}
