using FruitWarehouse.Core;
using System.Windows.Input;
using System.Windows;
using FruitWarehouse.Views;

namespace FruitWarehouse.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        public ICommand NewGameCommand { get; }
        public ICommand ExitCommand { get; }

        public MainViewModel()
        {
            NewGameCommand = new RelayCommand(StartNewGame);
            ExitCommand = new RelayCommand(ExitApplication);
        }

        private void StartNewGame(object parameter)
        {
            var gameWindow = new GameWindow();
            gameWindow.Show();

            if (parameter is Window window)
            {
                window.Close();
            }
        }

        private void ExitApplication(object parameter)
        {
            Application.Current.Shutdown();
        }
    }
}
