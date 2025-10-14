
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyMvvmApp.Models;
using MyMvvmApp.Repos;
using System.Collections.ObjectModel;

namespace MyMvvmApp.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private string _message = "Üdvözöllek a Nyári Tábor Foglaló asztali alkalmazásban. Kezdésnek hozz létre egy tábort!";

        private readonly CampRepo _campRepo = new CampRepo();
        private Camp? _selectedCamp;
        public ObservableCollection<Camp> Camps { get; }

        [ObservableProperty]
        private object _currentView = new object();

        public MainViewModel()
        {
            Camps = new ObservableCollection<Camp>(_campRepo.GetAll());
        }

        [RelayCommand(CanExecute = nameof(CanDeleteSelected))]
        private void DeleteSelected()
        {
            if (_selectedCamp is null) return;

            _campRepo.Remove(_selectedCamp);
            Camps.Remove(_selectedCamp);
            SelectedCamp = null;
        }

        private bool CanDeleteSelected() => _selectedCamp is not null;

        public Camp? SelectedCamp
        {
            get => _selectedCamp;
            set
            {
                SetProperty(ref _selectedCamp, value);
                DeleteSelectedCommand.NotifyCanExecuteChanged();
            }
        }

        public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }



        [RelayCommand]
        private void ShowControlPanelView()
        {
        }

        [RelayCommand]
        private void ShowCampsBrowserView()
        {
        }

        [RelayCommand]
        private void ShowCampCUDView()
        {
        }
    }
}
