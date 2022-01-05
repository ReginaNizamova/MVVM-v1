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
    }
}
