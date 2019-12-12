using System.Windows.Input;

namespace WpfClients
{
    public class CreateOrderWindowViewModel : NotifyPropertyChangedClass
    {
        private string _description;
        private ICommand _saveCommand;

        public string Description 
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        public ICommand SaveCommand
        {
            get => _saveCommand;
            set => SetProperty(ref _saveCommand, value);
        }
    }
}