using MFE.Domain.Models;
using MFEstrategyMaker.Commands;
using MFEstrategyMaker.Stores;
using MFEstrategyMaker.Stores.RegistersStore;
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
        public DbTableContentVM DbTableContentVM { get; }

        private readonly ObservableCollection<DbTableNamesListCompVM> _dbTableNamesListCompVM;
        public IEnumerable<DbTableNamesListCompVM> DbTableNamesListCompVM => _dbTableNamesListCompVM;
        private readonly SelectedDbTableStore _selectedDbTableStore;

        private DbTableNamesListCompVM? _selectedDbTableNamesList;
        public DbTableNamesListCompVM SelectedDbTableNamesList
        {
            get { return _selectedDbTableNamesList; }
            set
            {
                _selectedDbTableNamesList = value;
                OnPropertyChanged(nameof(SelectedDbTableNamesList));
                _selectedDbTableStore.SelectedDbTable = _selectedDbTableNamesList?.DbTableContentModel;
            }
        }
        public CTabTabelasViewModel(NavigationStore navigationStore)
        {
            TabName = "Tabelas";

            _selectedDbTableStore = new SelectedDbTableStore();

            NewDBTable = new OpenModalCommand<AddNewDBTableVM>(navigationStore,
                () => new AddNewDBTableVM(navigationStore));

            _dbTableNamesListCompVM = new ObservableCollection<DbTableNamesListCompVM>();
            DbTableContentVM = new DbTableContentVM(_selectedDbTableStore);

            _dbTableNamesListCompVM.Add(new DbTableNamesListCompVM(new DbTableContentModel("Constantes")));
            _dbTableNamesListCompVM.Add(new DbTableNamesListCompVM(new DbTableContentModel("Reuniões_COPOM")));

        }
    }
}
