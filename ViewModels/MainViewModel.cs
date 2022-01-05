using ControlStudy.Views;
using System.Windows.Controls;

namespace ControlStudy.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        public MainViewModel(Frame frame)
        {
            Frame = frame;
            Frame.Navigate(new AdminPage());           
        }

        private BaseViewModel _backCommand;
        public BaseViewModel BackCommand //Выполняется при нажатии на кнопку "Назад"
        {
            get
            {
                return _backCommand = new BaseViewModel(obj =>
                {
                    Frame.GoBack();
                    OnPropertyChanged("BackCommand");
                });
            }
        }
    }
}
