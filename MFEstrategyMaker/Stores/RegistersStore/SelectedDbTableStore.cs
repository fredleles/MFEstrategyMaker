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
        private DbTableContentModel _selectedDbTable;

        public DbTableContentModel SelectedDbTable
        {
            get { return _selectedDbTable; }
            set
            {
                _selectedDbTable = value;
                SelectedDbTableChanged?.Invoke();
            }
        }

    }
}
