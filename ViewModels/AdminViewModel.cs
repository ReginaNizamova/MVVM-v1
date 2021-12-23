using ControlStudy.Views;
using System.Windows.Controls;

namespace ControlStudy.ViewModels
{
    class AdminViewModel : BaseViewModel
    {
        public AdminViewModel(Frame frame)
        {
            Frame = frame;  
        }

        private BaseViewModel _usersCommand;
        public BaseViewModel UsersCommand //Выполняется при нажатии на кнопку "Пользователи"
        {
            get
            {
                return _usersCommand ?? (_usersCommand = new BaseViewModel(obj =>
                {
                    Frame.Navigate(new AdminUsersPage(Frame));
                }));
            }
        }


        private BaseViewModel _journalCommand;
        public BaseViewModel JournalCommand //Выполняется при нажатии на кнопку "Журнал"
        {
            get
            {
                return _journalCommand ?? (_journalCommand = new BaseViewModel(obj =>
                {
                    Frame.Navigate(new AdminJournalPage());
                }));
            }
        }
    }
}
