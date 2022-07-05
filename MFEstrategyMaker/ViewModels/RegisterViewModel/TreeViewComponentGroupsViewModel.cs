using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFEstrategyMaker.ViewModels.RegisterViewModel
{
    public class TreeViewComponentGroupsViewModel : ViewModelBase
    {

        private readonly ObservableCollection<TreeViewComponentRegistersViewModel> _treeViewComponentRegistersViewModel;
        public IEnumerable<TreeViewComponentRegistersViewModel> TreeViewComponentRegistersViewModel => _treeViewComponentRegistersViewModel;

        public string GroupName { get; }
        public TreeViewComponentGroupsViewModel(string groupName)
        {
            GroupName = groupName;

            _treeViewComponentRegistersViewModel = new ObservableCollection<TreeViewComponentRegistersViewModel>();
            _treeViewComponentRegistersViewModel.Add(new TreeViewComponentRegistersViewModel("Registro1"));
            _treeViewComponentRegistersViewModel.Add(new TreeViewComponentRegistersViewModel("Registro2"));
            _treeViewComponentRegistersViewModel.Add(new TreeViewComponentRegistersViewModel("Registro3"));

        }

    }
}
