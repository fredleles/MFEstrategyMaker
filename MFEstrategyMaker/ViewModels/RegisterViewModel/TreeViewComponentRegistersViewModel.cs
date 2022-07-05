using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFEstrategyMaker.ViewModels.RegisterViewModel
{
    public class TreeViewComponentRegistersViewModel : ViewModelBase
    {
        public string RegisterName { get; }

        public TreeViewComponentRegistersViewModel(string registerName)
        {
            RegisterName = registerName;
        }
    }
}
