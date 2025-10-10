using System.ComponentModel;

namespace MyMvvmApp.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _message = "Üdvözöllek a Nyári Tábor Foglaló asztali alkalmazásban. Kezdésnek hozz létre egy tábort!";

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
