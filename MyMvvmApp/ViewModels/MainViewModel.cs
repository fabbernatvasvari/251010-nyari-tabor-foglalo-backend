using System.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MyMvvmApp.Models;
using MyMvvmApp.Repos;
using System.Collections.ObjectModel;

namespace MyMvvmApp.ViewModels
{
    public partial class MainViewModel : INotifyPropertyChanged//, ObservableObject
    {
        private string _message = "Üdvözöllek a Nyári Tábor Foglaló asztali alkalmazásban. Kezdésnek hozz létre egy tábort!";

        private readonly CampRepo _campRepo = new CampRepo();

        //[ObservableProperty]
        //[NotifyCanExecuteChangedFor(nameof(DeleteSelectedCommand))]
        private Camp? selectedCamp;

        public ObservableCollection<Camp> Camps { get; }

        public MainViewModel()
        {
            
            Camps = new ObservableCollection<Camp>(_campRepo.GetAll());
        }

        [RelayCommand(CanExecute = nameof(CanDeleteSelected))]
        private void DeleteSelected()
        {
            if (selectedCamp is null) return;

            _campRepo.Remove(selectedCamp);
            Camps.Remove(selectedCamp);
            selectedCamp = null;
        }

        /// <summary>
        /// Megadja mikor lehet törölni az osztályt
        /// </summary>
        /// <returns>true ha az osztály létszáma nulla, vagyis ha nincs diák az osztályba</returns>
        private bool CanDeleteSelected()
        {
            return true;
        }

        public Camp? SelectedCamp
        {
            get => selectedCamp;
            set
            {
                if (selectedCamp != value)
                {
                    selectedCamp = value;
                    OnPropertyChanged(nameof(SelectedCamp));
                    DeleteSelectedCommand.NotifyCanExecuteChanged();
                }
            }
        }

        public string Message
        {
            get => _message;
            set
            {
                if (_message != value)
                {
                    _message = value;
                    OnPropertyChanged(nameof(Message));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
