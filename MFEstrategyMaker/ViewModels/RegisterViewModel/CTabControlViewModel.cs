using MFEstrategyMaker.Stores.RegistersStore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFEstrategyMaker.ViewModels.RegisterViewModel
{
    public class CTabControlViewModel : ViewModelBase
    {
        private readonly CTabControlStore _cTabControlStore;
        public ObservableCollection<CTabItemViewModel> Items => _cTabControlStore.CurrentTabsViewModel;

        public CTabControlViewModel(CTabControlStore cTabControlStore)
        {
            _cTabControlStore = cTabControlStore;
            //items.CollectionChanged += Items_CollectionChanged;
            //items.Add(new CTabInicioViewModel());
        }

        private void Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            CTabItemViewModel tab;
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    tab = (CTabItemViewModel)e.NewItems[0];
                    //tab.CloseRequested += OnTabCloseRequested;
                    break;
                case NotifyCollectionChangedAction.Remove:
                    tab = (CTabItemViewModel)e.OldItems[0];
                    //tab.CloseRequested -= OnTabCloseRequested;
                    break;
            }
        }
        private void OnTabCloseRequested(object sender, EventArgs e)
        {
            //items.Remove((CTabItemViewModel) sender);
        }
    }
}
