using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1.Pages.Dlg
{
    /// <summary>
    /// Interaction logic for UserDlgPage.xaml
    /// </summary>
    public partial class UserDlgPage : Page
    {
        private Page ParentPage;
        private int UserId;
        public UserDlgPage(Page ParentPage, int UserId)
        {
            InitializeComponent();
            this.ParentPage = ParentPage;
            this.UserId = UserId;
            LoadInfo();
        }
        private void LoadInfo()
        {
            if (UserId < 0)
            {
                NamePageLabel.Content = "Добавить нового пользователя";
            }
            else NamePageLabel.Content = "Изменить пользователя";

        }
        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            (ParentPage as Pages.UserPage).HideDlg();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            (ParentPage as Pages.UserPage).HideDlg();
        }
    }
}
