using System.Windows;
using Unity;

namespace WpfClients
{
    public partial class App : Application
    {
        private IDataManager _dataManager;

        public App()
        {
            Exit += OnAppExit;
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _dataManager = new DataManager();

            var container = new UnityContainer();
            container.RegisterInstance<IUnityContainer>(container);
            container.RegisterInstance<IClientManager>(_dataManager.GetClientManager());
            container.RegisterInstance<IOrderManager>(_dataManager.GetOrderManager());
           
            var mainWindow = new MainWindow{ DataContext = container.Resolve<MainWindowViewModel>() };
            
            Current.MainWindow = mainWindow;
            Current.MainWindow.Show();
        }

        private void OnAppExit(object sender, ExitEventArgs e)
        {
            Exit -= OnAppExit;
            _dataManager?.Dispose();
        }
    }
}