using MFE.Domain.Models;
using MFEstrategyMaker.Stores;
using MFEstrategyMaker.Stores.RegistersStore;
using MFEstrategyMaker.ViewModels.RegisterViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFEstrategyMaker.Commands.Database
{
    public class EditTableCommand : AsyncCommandBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly DbTablesNameStore _dbTablesNameStore;
        private readonly AddNewDBTableVM _addNewDBTableVM;
        public EditTableCommand(AddNewDBTableVM addNewDBTableVM, NavigationStore navigationStore, DbTablesNameStore dbTablesNameStore)
        {
            _addNewDBTableVM = addNewDBTableVM;
            _navigationStore = navigationStore;
            _dbTablesNameStore = dbTablesNameStore;
        }
        public override async Task ExecuteAsync(object parameter)
        {
            DbTablePropsModel dbTablePropsModel = new DbTablePropsModel(
                _addNewDBTableVM.TableGuid,
                _addNewDBTableVM.TableNameId);
            try
            {
                await _dbTablesNameStore.Update(dbTablePropsModel);
                _navigationStore.CloseModal();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
