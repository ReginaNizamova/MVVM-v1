using ControlStudy.ViewModels;
using System;
using System.Windows;


namespace ControlStudy.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();           
            DataContext = new MainViewModel(MainFrame);
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                BackButton.Visibility = Visibility.Visible;
            }

            else
            {
                BackButton.Visibility = Visibility.Hidden;
            }
        }
    }
}
