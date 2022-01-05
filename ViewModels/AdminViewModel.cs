using ControlStudy.Models;
using ControlStudy.Views;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ControlStudy.ViewModels
{
    class AdminViewModel : BaseViewModel
    {
        public AdminViewModel(Frame frame, DataGrid dataGrid)
        {
            Frame = frame;
            DataGrid = dataGrid;
        }

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


        private BaseViewModel _addUsersCommand;
        public BaseViewModel AddUsersCommand //Выполняется при нажатии на кнопку "Добавить пользователя"
        {
            get
            {
                return _addUsersCommand ?? (_addUsersCommand = new BaseViewModel(obj =>
                {
                    AdminUsersAddWindow adminUsersAddWindow = new AdminUsersAddWindow();
                    adminUsersAddWindow.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
                    adminUsersAddWindow.ShowDialog();
                }));
            }
        }


        private BaseViewModel _changeUsersCommand;
        public BaseViewModel ChangeUsersCommand //Выполняется при нажатии на кнопку "Изменить пользователя"
        {
            get
            {
                return _changeUsersCommand ?? (_changeUsersCommand = new BaseViewModel(obj =>
                {
                    //Frame.Navigate(new AdminUsersAddPage(Frame)); 
                }));
            }
        }


        private BaseViewModel _deleteUsersCommand;
        public BaseViewModel DeleteUsersCommand //Выполняется при нажатии на кнопку "Удалить пользователя"
        {
            get
            {
                return _deleteUsersCommand ?? (_deleteUsersCommand = new BaseViewModel(obj =>
                {
                    //Frame.Navigate(new AdminUsersAddPage(Frame));
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


        private BaseViewModel _saveAddCommand;
        public BaseViewModel SaveAddCommand //Выполняется при нажатии на кнопку "Сохранить" в окне добавления пользователя
        {
            get
            {
                return _saveAddCommand;
            }

            set
            {

            }
        }


        private BaseViewModel _teacherRBCommand;
        public BaseViewModel TeacherRBCommand //Выполняется при нажатии на RadioButton "Преподаватель"
        {
            get
            {
                return _teacherRBCommand ?? (_teacherRBCommand = new BaseViewModel(obj =>
                {
                    DataGrid.ItemsSource = ControlStudyEntities.GetContext().Teachers.ToList();
                    DataGrid.Columns[5].Visibility = Visibility.Visible;
                    DataGrid.Columns[4].Visibility = Visibility.Collapsed;
                    OnPropertyChanged("TeacherRBCommand");
                }));
            }
        }


        private BaseViewModel _studentRBCommand;
        public BaseViewModel StudentRBCommand //Выполняется при нажатии на RadioButton "Студент"
        {
            get
            {
                return _studentRBCommand ?? (_studentRBCommand = new BaseViewModel(obj =>
                {
                    DataGrid.ItemsSource = ControlStudyEntities.GetContext().Students.ToList();
                    DataGrid.Columns[4].Visibility = Visibility.Visible;
                    DataGrid.Columns[5].Visibility = Visibility.Collapsed;
                    OnPropertyChanged("StudentRBCommand");
                }));
            }
        }


        private BaseViewModel _adminRBCommand;
        public BaseViewModel AdminRBCommand //Выполняется при нажатии на RadioButton "Администратор"
        {
            get
            {
                return _adminRBCommand ?? (_adminRBCommand = new BaseViewModel(obj =>
                {
                    DataGrid.ItemsSource = ControlStudyEntities.GetContext().Admins.ToList();
                    DataGrid.Columns[4].Visibility = Visibility.Collapsed;
                    DataGrid.Columns[5].Visibility = Visibility.Collapsed;
                    OnPropertyChanged("AdminRBCommand");
                }));
            }
        }
    }
}
