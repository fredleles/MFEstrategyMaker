using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFEstrategyMaker.ViewModels.RegisterViewModel
{
    public class TreeViewComponentViewModel : ViewModelBase
    {
        private readonly ObservableCollection<TreeViewComponentCollectionsViewModel> _treeViewComponentCollectionsViewModels;
        public IEnumerable<TreeViewComponentCollectionsViewModel> TreeViewComponentCollectionsViewModels => _treeViewComponentCollectionsViewModels;
        // verificar se as consequencias de atribuir T no tipo IEnumerable. Virou genérico?
        public TreeViewComponentViewModel()
        {
            _treeViewComponentCollectionsViewModels = new ObservableCollection<TreeViewComponentCollectionsViewModel>
            {
                new TreeViewComponentCollectionsViewModel("Collection1"),
                new TreeViewComponentCollectionsViewModel("Collection2")
            };
        }
    }
}
