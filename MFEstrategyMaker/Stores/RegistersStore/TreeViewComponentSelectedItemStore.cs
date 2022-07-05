using MFE.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFEstrategyMaker.Stores.RegistersStore
{
    public class TreeViewComponentSelectedItemStore
    {
        private DataRegisterModel _treeViewSelectedItemStore;
        public DataRegisterModel TreeViewSelectedItemStore
        {
            get { return _treeViewSelectedItemStore; }
            set
            {
                _treeViewSelectedItemStore = value;
                TreeViewSelectedItemStoreChanged?.Invoke();
            }
        }

        public event Action TreeViewSelectedItemStoreChanged;
    }
}
