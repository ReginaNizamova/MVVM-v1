using ControlStudy.ViewModels;
using System.Windows.Controls;

namespace ControlStudy.Views
{
    public partial class AdminUsersPage : Page
    {
        public AdminUsersPage(Frame frame)
        {
            InitializeComponent();
            DataContext = new AdminViewModel(frame);
        }
    }
}
