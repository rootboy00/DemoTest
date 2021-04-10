using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace WpfApp1.Pages
{
    /// <summary>
    /// Interaction logic for NewsPage.xaml
    /// </summary>
    public partial class NewsPage : Page
    {
        private SqlConnection DataBaseSqlConnection;
        private DataSet NewsDataSet;
        public NewsPage( SqlConnection DataBaseSqlConnection)
        {
            InitializeComponent();
            this.DataBaseSqlConnection = DataBaseSqlConnection;
            NewsDataSet = new DataSet();
            UpdateDataGrid();

        }

        public void UpdateDataGrid()
        {
            String S = "Select n.news_id, n.header_char,n.description,n.full_text,n.date_make,n.date_update, k.name_kategory " +
                       "from news n " +
                       "inner join kategories k on(k.kategory_id = n.kategory_id)";
            SqlDataAdapter DataAdapter = new SqlDataAdapter(S, DataBaseSqlConnection);
            NewsDataSet.Clear();
            DataAdapter.Fill(NewsDataSet);
            NewsDataGrid.DataContext = NewsDataSet.Tables[0];
            NewsDataGrid.SelectedValuePath = "news_id";





        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Page OpenPage = new Pages.Dlg.NewsDlgPage(this, -1);
            DlgFrame.Navigate(OpenPage);
            Grid.SetColumnSpan(NewsDataGrid, 1);
            DlgFrame.Visibility = Visibility.Visible;
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            Page OpenPage = new Pages.Dlg.NewsDlgPage(this, 1);
            DlgFrame.Navigate(OpenPage);
            Grid.SetColumnSpan(NewsDataGrid, 1);
            DlgFrame.Visibility = Visibility.Visible;
        }

        public void HideDlg()
        {
            DlgFrame.Navigate(null);
            DlgFrame.Visibility = Visibility.Hidden;
            Grid.SetColumnSpan(NewsDataGrid, 2);
        }

    }
}
