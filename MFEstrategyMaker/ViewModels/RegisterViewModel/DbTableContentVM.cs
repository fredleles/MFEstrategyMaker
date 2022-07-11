using MFE.Domain.Models;
using MFEstrategyMaker.Stores.RegistersStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFEstrategyMaker.ViewModels.RegisterViewModel
{
    public class DbTableContentVM : ViewModelBase
    {
        private readonly SelectedDbTableStore _selectedDbTableStore;
        private DbTablePropsModel? SelectedDbTable => _selectedDbTableStore.SelectedDbTable;

        public bool HasSelectedDbTable => SelectedDbTable != null;
        public string? TableNameId => SelectedDbTable?.TableNameId;

        public DbTableContentVM(SelectedDbTableStore selectedDbTableStore)
        {
            _selectedDbTableStore = selectedDbTableStore;
            _selectedDbTableStore.SelectedDbTableChanged += SelectedDbTableItemChanged;
        }

        public override void Dispose()
        {
            _selectedDbTableStore.SelectedDbTableChanged -= SelectedDbTableItemChanged;
            base.Dispose();
        }

        private void SelectedDbTableItemChanged()
        {
            OnPropertyChanged(nameof(HasSelectedDbTable));
            OnPropertyChanged(nameof(TableNameId));
        }
    }
}
