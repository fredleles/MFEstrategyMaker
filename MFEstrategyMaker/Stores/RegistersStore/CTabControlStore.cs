using MFEstrategyMaker.ViewModels.RegisterViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFEstrategyMaker.Stores.RegistersStore
{
    public class CTabControlStore
    {

        public event Action CurrentTabsViewModelChange;
        private ObservableCollection<CTabItemViewModel> _currentTabsViewModel;

        public CTabControlStore()
        {
            _currentTabsViewModel = new ObservableCollection<CTabItemViewModel>();
        }
        public ObservableCollection<CTabItemViewModel> CurrentTabsViewModel
        {
            get { return _currentTabsViewModel; }
        }

        public void AddNewTab(CTabItemViewModel tab)
        {
            _currentTabsViewModel.Add(tab);
            CurrentTabsViewModelChange?.Invoke();
        }

        public void CloseTab(CTabItemViewModel tab)
        {
            _currentTabsViewModel.Remove(tab);
            CurrentTabsViewModelChange?.Invoke();
        }
    }
}
