using MFEstrategyMaker.Stores;

namespace MFEstrategyMaker.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;
        public ViewModelBase CurrentModal => _navigationStore.CurrentModal;
        public bool IsModalOpen => _navigationStore.IsModalOpen;

        public MainViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;

            _navigationStore.CurrentModalChange += OnCurrentModalChanged;
            _navigationStore.CurrentViewModelChange += OnCurrentViewModelChanged;
        }

        public override void Dispose()
        {
            _navigationStore.CurrentModalChange -= OnCurrentModalChanged;
            _navigationStore.CurrentViewModelChange -= OnCurrentViewModelChanged;

            base.Dispose();
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
        private void OnCurrentModalChanged()
        {
            OnPropertyChanged(nameof(CurrentModal));
            OnPropertyChanged(nameof(IsModalOpen));
        }
    }
}
