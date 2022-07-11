using MFE.Domain.Models;
using MFEstrategyMaker.Commands;
using MFEstrategyMaker.Commands.Database;
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
    public class AddNewDBTableVM : ViewModelBase
    {
        public ICommand CloseModalCommand { get; }
        public ICommand SubmitCommand { get; }
        public Guid TableGuid { get; }

        private string _tableNameId;
        public string TableNameId
        {
            get { return _tableNameId; }
            set
            {
                _tableNameId = value;
                OnPropertyChanged(nameof(TableNameId));
                OnPropertyChanged(nameof(CanSubmit));
            }
        }
        public bool CanSubmit => !string.IsNullOrEmpty(TableNameId);

        public AddNewDBTableVM(NavigationStore navigationStore, DbTablesNameStore dbTablesNameStore)
        {
            // new
            CloseModalCommand = new CloseModalCommand(navigationStore);
            SubmitCommand = new CreateNewTableCommand(this, navigationStore, dbTablesNameStore);

            _tableNameId = "";
        }
        public AddNewDBTableVM(NavigationStore navigationStore, DbTablesNameStore dbTablesNameStore, DbTablePropsModel dbTablePropsModel)
        {
            // edit
            _tableNameId = dbTablePropsModel.TableNameId;
            TableGuid = dbTablePropsModel.Id;
            CloseModalCommand = new CloseModalCommand(navigationStore);
            SubmitCommand = new EditTableCommand(this, navigationStore, dbTablesNameStore);

        }
    }
}
