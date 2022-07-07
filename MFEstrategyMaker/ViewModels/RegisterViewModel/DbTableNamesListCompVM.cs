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
        public string TableName { get; }
        public ICommand EditCommand { get; }
        public ICommand DropCommand { get; }

        public DbTableNamesListCompVM(string tableName)
        {
            TableName = tableName;
        }
    }
}
