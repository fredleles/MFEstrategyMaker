

using MFEstrategyMaker.Commands;
using MFEstrategyMaker.Commands.RegistersCommands;
using MFEstrategyMaker.Stores;
using MFEstrategyMaker.Stores.RegistersStore;
using MFEstrategyMaker.ViewModels.RegisterViewModel;
using System.Windows.Input;

namespace MFEstrategyMaker.ViewModels
{
    public class FileManagerViewModel : ViewModelBase
    {
        public TreeViewComponentViewModel TreeViewComponentViewModel { get; }
        public CTabControlViewModel CTabControlViewModel { get; }

        private readonly CTabControlStore _tabControlStore;

        public ICommand AddDailyRegisterCommand { get; }
        public ICommand NewTabTabelasCommand { get; }
        public FileManagerViewModel(NavigationStore navigationStore)
        {
            _tabControlStore = new CTabControlStore();
            _tabControlStore.AddNewTab(new CTabInicioViewModel());
            CTabControlViewModel = new CTabControlViewModel(_tabControlStore);


            TreeViewComponentViewModel = new TreeViewComponentViewModel();

            AddDailyRegisterCommand = new OpenModalCommand<AddRegisterModal>(navigationStore,
                () => new AddRegisterModal(navigationStore));

            NewTabTabelasCommand = new NewTabCommand<CTabItemViewModel>(_tabControlStore, () => new CTabTabelasViewModel(navigationStore));

        }


    }
}
