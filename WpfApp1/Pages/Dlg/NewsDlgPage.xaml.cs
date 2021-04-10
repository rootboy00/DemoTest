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
    /// Interaction logic for NewsDlgPage.xaml
    /// </summary>
    public partial class NewsDlgPage : Page
    {
        private Page ParentPage;
        private int NewsID;
        public NewsDlgPage(Page ParentPage, int NewsID)
        {
            InitializeComponent();
            this.ParentPage = ParentPage;
            this.NewsID = NewsID;
            LoadInfo();
        }

        private void LoadInfo()
        {
            if (NewsID < 0)
            {
                NamePageLabel.Content = "Добавить новую новость";
            }
            else NamePageLabel.Content = "Изменить новость";

        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            (ParentPage as Pages.NewsPage).HideDlg();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            (ParentPage as Pages.NewsPage).HideDlg();
        }
    }
}
