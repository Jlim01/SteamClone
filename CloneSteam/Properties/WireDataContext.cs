using CloneSteam.Library.Local.ViewModels;
using CloneSteam.Library.UI.Units.Detail;
using CloneSteam.Library.UI.Views;
using Prism.Mvvm;

namespace CloneSteam.Properties
{
    internal class WireDataContext
    {
        static public void WireVIewModelModule()
        {
            //ViewModelLocationProvider.Register<MainWindow, MainWindowViewModel>();
            //ViewModelLocationProvider.Register<LoginWindow, LoginWindowViewModel>();
            //ViewModelLocationProvider.Register<MainContent, MainContentViewModel>();
            ViewModelLocationProvider.Register<GameInfoDetail, GameInfoViewModel>();
        }
    }
}
