using DialogSample.Interfaces;
using DialogSample.Services;
using DialogSample.ViewModels;
using DialogSample.Views;
using System.Configuration;
using System.Data;
using System.Windows;

namespace DialogSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            IDialogService dialogService = new DialogService(MainWindow);

            dialogService.Register<DialogViewModel, DialogWindow>();

            var viewModel = new MainWindowViewModel(dialogService);
            var view = new MainWindow { DataContext = viewModel };

            view.ShowDialog();
        }
    }

}
