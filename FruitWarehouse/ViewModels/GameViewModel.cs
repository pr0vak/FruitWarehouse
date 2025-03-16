using FruitWarehouse.Core;
using FruitWarehouse.Views;
using System.Windows;
using System.Windows.Input;

namespace FruitWarehouse.ViewModels
{
    public class GameViewModel : ObservableObject
    {
        public ICommand BackToMenuCommand { get; }

        public GameViewModel()
        {
            BackToMenuCommand = new RelayCommand(BackToMenu);
        }

        private void BackToMenu(object parameter)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();

            if (parameter is Window window)
            {
                window.Close();
            }
        }
    }
}