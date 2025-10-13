
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
        private readonly object _studentViewModel = new object();
        private readonly object _schoolClassViewModel = new object();
        private readonly object _controlPanelViewModel = new object();
        public ObservableCollection<Camp> Camps { get; }


        private object _currentView = new object();
        public object CurrentView
        {
            get => _currentView;
            set => SetProperty(ref _currentView, value);
        }

        public MainViewModel()
        {
            Camps = new ObservableCollection<Camp>(_campRepo.GetAll());
            _currentView = _controlPanelViewModel;
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
        private void ShowControlPanalView()
        {
            CurrentView = _controlPanelViewModel;
        }

        [RelayCommand]
        private void ShowStudentView()
        {
            CurrentView = _studentViewModel;
        }
    }
}
