using MFEstrategyMaker.Commands;
using MFEstrategyMaker.Stores;
using System.Windows.Input;

namespace MFEstrategyMaker.ViewModels
{
    public class StarterPageViewModel : ViewModelBase
    {
        public ICommand NavigateFileManagerCommand { get; }

        public StarterPageViewModel(NavigationStore navigationStore)
        {
            NavigateFileManagerCommand = new NavigateCommand<FileManagerViewModel>(navigationStore,
                () => new FileManagerViewModel(navigationStore));
        }


    }
}
