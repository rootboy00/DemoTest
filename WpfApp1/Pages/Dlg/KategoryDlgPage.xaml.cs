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
    /// Interaction logic for KategoryDlgPage.xaml
    /// </summary>
    public partial class KategoryDlgPage : Page
    {
        private Page ParentPage;
        private int KategoryID;
        public KategoryDlgPage(Page ParentPage, int KategoryID)
        {
            InitializeComponent();
            this.ParentPage = ParentPage;
            this.KategoryID = KategoryID;
            LoadInfo();
        }
        private void LoadInfo()
        {
            if (KategoryID < 0)
            {
                NamePageLabel.Content = "Добавить новую категорию";
            }
            else NamePageLabel.Content = "Изменить категорию";

        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            (ParentPage as Pages.KategoryPage).HideDlg();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            (ParentPage as Pages.KategoryPage).HideDlg();
        }
    }
}
