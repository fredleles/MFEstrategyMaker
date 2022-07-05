using MFEstrategyMaker.ViewModels;
using System;

namespace MFEstrategyMaker.Stores
{
    public class NavigationStore
    {
        public event Action CurrentViewModelChange;
        public event Action CurrentModalChange;

        private ViewModelBase _currentViewModel;
        private ViewModelBase? _currentModal;
        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                //_currentViewModel.Dispose();
                _currentViewModel = value;
                CurrentViewModelChange?.Invoke();
            }
        }

        public ViewModelBase CurrentModal
        {
            get => _currentModal;
            set
            {
                //_currentModal.Dispose();
                _currentModal = value;
                CurrentModalChange?.Invoke();
            }
        }
        public bool IsModalOpen => CurrentModal != null;

        public void CloseModal()
        {
            _currentModal = null;
            CurrentModalChange?.Invoke();
        }
    }
}
