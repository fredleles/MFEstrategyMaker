using MFE.Domain.Models;
using MFEstrategyMaker.Commands;
using MFEstrategyMaker.Stores;
using MFEstrategyMaker.Stores.RegistersStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MFEstrategyMaker.ViewModels.RegisterViewModel
{
    public class DbTableNamesListCompVM : ViewModelBase
    {
        public DbTablePropsModel DbTablePropsModel { get; private set; }
        public string TableNameId => DbTablePropsModel.TableNameId;
        public ICommand EditCommand { get; }
        public ICommand DropCommand { get; }

        public DbTableNamesListCompVM(DbTablePropsModel dbTablePropsModel, NavigationStore navigationStore, DbTablesNameStore dbTablesNameStore)
        {
            DbTablePropsModel = dbTablePropsModel;
            EditCommand = new OpenModalCommand<AddNewDBTableVM>(navigationStore,
               () => new AddNewDBTableVM(navigationStore, dbTablesNameStore, DbTablePropsModel));
        }

        public void Update(DbTablePropsModel dbTablePropsModel)
        {
            DbTablePropsModel = dbTablePropsModel;
            OnPropertyChanged(nameof(TableNameId));
        }
    }
}
