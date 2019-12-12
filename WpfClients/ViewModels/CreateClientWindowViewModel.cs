using System.Windows.Input;

namespace WpfClients
{
    public class CreateClientWindowViewModel : NotifyPropertyChangedClass
    {
        private string _name;
        private string _address;
        private bool _isVip;
        private ICommand _saveCommand;

        /// <summary>
        /// Имя клиента
        /// </summary>
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        /// <summary>
        /// Адресс клиента
        /// </summary>
        public string Address
        {
            get => _address;
            set => SetProperty(ref _address, value);
        }

        /// <summary>
        /// VIP
        /// </summary>
        public bool VIP
        {
            get => _isVip;
            set => SetProperty(ref _isVip, value);
        }

        public ICommand SaveCommand 
        { 
            get => _saveCommand; 
            set => SetProperty(ref _saveCommand, value);
        }
    }
}