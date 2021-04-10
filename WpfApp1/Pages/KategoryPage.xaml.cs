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
    /// Interaction logic for KategoryPage.xaml
    /// </summary>
    public partial class KategoryPage : Page
    {
        private SqlConnection DataBaseSqlConnection;
        private DataSet WorkDataSet;
        public KategoryPage(SqlConnection DataBaseSqlConnection)
        {
            InitializeComponent();
            this.DataBaseSqlConnection = DataBaseSqlConnection;
            WorkDataSet = new DataSet();
            UpdateDataGrid();
        }


        public void UpdateDataGrid()
        {
            String S = "select kategory_id, name_kategory  from kategories";
            SqlDataAdapter DataAdapter = new SqlDataAdapter(S, DataBaseSqlConnection);
            WorkDataSet.Clear();
            DataAdapter.Fill(WorkDataSet);
            WorkDataGrid.DataContext = WorkDataSet.Tables[0];
            WorkDataGrid.SelectedValuePath = "kategory_id";
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Page OpenPage = new Pages.Dlg.KategoryDlgPage( this, -1 );
            DlgFrame.Navigate(OpenPage);
            Grid.SetColumnSpan(WorkDataGrid, 1);
            DlgFrame.Visibility = Visibility.Visible;
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            Page OpenPage = new Pages.Dlg.KategoryDlgPage(this, 1);
            DlgFrame.Navigate(OpenPage);
            Grid.SetColumnSpan(WorkDataGrid, 1);
            DlgFrame.Visibility = Visibility.Visible;
        }

        public void HideDlg()
        {
            DlgFrame.Navigate(null);
            DlgFrame.Visibility = Visibility.Hidden;
            Grid.SetColumnSpan(WorkDataGrid, 2);
        }

    }
}
