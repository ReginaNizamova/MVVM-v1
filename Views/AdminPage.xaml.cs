using ControlStudy.ViewModels;
using System.Windows.Controls;

namespace ControlStudy.Views
{
    public partial class AdminPage : Page
    {
        public AdminPage(Frame frame)
        {
            InitializeComponent();
            DataContext = new AdminViewModel(frame);
        }
    }
}
