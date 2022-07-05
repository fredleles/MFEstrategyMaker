using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFEstrategyMaker.ViewModels.RegisterViewModel
{
    public abstract class CTabItemViewModel : ViewModelBase
    {
        public string TabName { get; set; }

        public CTabItemViewModel()
        {

        }
    }
}
