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
    /// Interaction logic for CommentsDlgPage.xaml
    /// </summary>
    public partial class CommentsDlgPage : Page
    {
        private Page ParentPage;
        private int Comm_Id;

        public CommentsDlgPage(Page ParentPage, int Comm_Id)
        {
            InitializeComponent();
            this.ParentPage = ParentPage;
            this.Comm_Id = Comm_Id;
            LoadInfo();
        }

        private void LoadInfo()
        {
            if (Comm_Id < 0)
            {
                NamePageLabel.Content = "Добавить новый комментарий";
            }
            else NamePageLabel.Content = "Изменить комментарий";

        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            (ParentPage as Pages.CommentsPage).HideDlg();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            (ParentPage as Pages.CommentsPage).HideDlg();
        }
    }
}
