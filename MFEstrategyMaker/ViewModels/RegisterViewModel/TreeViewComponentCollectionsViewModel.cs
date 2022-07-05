using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFEstrategyMaker.ViewModels.RegisterViewModel
{
    public class TreeViewComponentCollectionsViewModel : ViewModelBase
    {

        private readonly ObservableCollection<TreeViewComponentGroupsViewModel> _treeViewComponentGroupsViewModels;
        public IEnumerable<TreeViewComponentGroupsViewModel> TreeViewComponentGroupsViewModels => _treeViewComponentGroupsViewModels;
        public string CollectionName { get; }
        public TreeViewComponentCollectionsViewModel(string collectionName)
        {
            CollectionName = collectionName;

            _treeViewComponentGroupsViewModels = new ObservableCollection<TreeViewComponentGroupsViewModel>();
            _treeViewComponentGroupsViewModels.Add(new TreeViewComponentGroupsViewModel("Group1"));
            _treeViewComponentGroupsViewModels.Add(new TreeViewComponentGroupsViewModel("Group2"));

        }

    }
}
