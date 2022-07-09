using MFE.Domain.Models;
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
        public DbTableContentModel DbTableContentModel { get; }
        public string TableNameId => DbTableContentModel.TableNameId;
        public ICommand EditCommand { get; }
        public ICommand DropCommand { get; }

        public DbTableNamesListCompVM(DbTableContentModel dbTabbleContentModel)
        {
            DbTableContentModel = dbTabbleContentModel;
        }
    }
}
