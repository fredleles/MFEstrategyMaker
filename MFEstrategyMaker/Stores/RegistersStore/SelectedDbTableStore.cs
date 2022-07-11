using MFE.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFEstrategyMaker.Stores.RegistersStore
{
    public class SelectedDbTableStore
    {
        public event Action SelectedDbTableChanged;
        private DbTablePropsModel _selectedDbTable;
        private readonly DbTablesNameStore _dbTablesNameStore;

        public DbTablePropsModel SelectedDbTable
        {
            get { return _selectedDbTable; }
            set
            {
                _selectedDbTable = value;
                SelectedDbTableChanged?.Invoke();
            }
        }

        public SelectedDbTableStore(DbTablesNameStore dbTablesNameStore)
        {
            _dbTablesNameStore = dbTablesNameStore;
            _dbTablesNameStore.DbTableUpdate += _dbTablesNameStore_DbTableUpdate;
        }

        private void _dbTablesNameStore_DbTableUpdate(DbTablePropsModel dbTablePropsModel)
        {
            if(dbTablePropsModel.Id == SelectedDbTable?.Id)
            {
                SelectedDbTable = dbTablePropsModel;
            }
        }
    }
}
