using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfClients
{
    public abstract class NotifyPropertyChangedClass : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        protected bool SetProperty<T>(ref T reference, T value, [CallerMemberName]string propertyName = "")
        {
            if (reference?.Equals(value) ?? false)
                return false;

            reference = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}