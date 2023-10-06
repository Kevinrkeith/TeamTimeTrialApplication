using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TimeTrialsWPFApplication.Misc;
using TimeTrialsWPFApplication.ViewModels;

namespace TimeTrialsWPFApplication.Views
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly NavigationStore navigation;
        public App()
        {
            navigation = new NavigationStore();
        }
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            navigation.CurrentViewModel = new TimeTrialsViewModel(navigation);

            MainWindow = new MainWindow()
            {
                DataContext = new MainWindowModel(navigation)
            };
            MainWindow.Show();
        }
    }
}
