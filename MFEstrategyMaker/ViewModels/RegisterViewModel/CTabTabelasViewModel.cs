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

        private readonly DbTablesNameStore _dbTablesNameStore;
        private readonly NavigationStore _navigationStore;

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
                _selectedDbTableStore.SelectedDbTable = _selectedDbTableNamesList?.DbTablePropsModel;
            }
        }
        public CTabTabelasViewModel(NavigationStore navigationStore)
        {
            TabName = "Tabelas";

            _dbTablesNameStore = new DbTablesNameStore();
            _selectedDbTableStore = new SelectedDbTableStore(_dbTablesNameStore);
            _navigationStore = navigationStore;

            NewDBTable = new OpenModalCommand<AddNewDBTableVM>(_navigationStore,
                () => new AddNewDBTableVM(_navigationStore, _dbTablesNameStore));

            _dbTableNamesListCompVM = new ObservableCollection<DbTableNamesListCompVM>();
            DbTableContentVM = new DbTableContentVM(_selectedDbTableStore);

            _dbTablesNameStore.DbTableCreated += DbTablesNameStore_DbTableCreated;
            _dbTablesNameStore.DbTableUpdate += DbTablesNameStore_DbTableUpdate;
        }
        public override void Dispose()
        {
            _dbTablesNameStore.DbTableCreated -= DbTablesNameStore_DbTableCreated;
            _dbTablesNameStore.DbTableUpdate -= DbTablesNameStore_DbTableUpdate;
            base.Dispose();
        }
        private void DbTablesNameStore_DbTableCreated(DbTablePropsModel dbTablePropsModel)
        {
            _dbTableNamesListCompVM.Add(new DbTableNamesListCompVM(dbTablePropsModel, _navigationStore, _dbTablesNameStore));
        }
        private void DbTablesNameStore_DbTableUpdate(DbTablePropsModel dbTablePropsModel)
        {
            DbTableNamesListCompVM? itemToUpdate =
                _dbTableNamesListCompVM.FirstOrDefault(y => y.DbTablePropsModel.Id == dbTablePropsModel.Id);

            if (itemToUpdate != null)
            {
                itemToUpdate.Update(dbTablePropsModel);
            }
        }
    }
}
