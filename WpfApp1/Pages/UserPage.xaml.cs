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
    /// Interaction logic for UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        private SqlConnection DataBaseSqlConnection;
        private DataSet UserDataSet;
        public UserPage( SqlConnection DataBaseSqlConnection )
        {
            InitializeComponent();
            this.DataBaseSqlConnection = DataBaseSqlConnection;
            UserDataSet = new DataSet();
            UpdateDataGrid();
        }
    
        public void UpdateDataGrid()
        {
            String S = "Select user_id, login,email,password " +
                       "from users";
            SqlDataAdapter DataAdapter = new SqlDataAdapter(S, DataBaseSqlConnection);
            UserDataSet.Clear();
            DataAdapter.Fill(UserDataSet);
            UserDataGrid.DataContext = UserDataSet.Tables[0];
            UserDataGrid.SelectedValuePath = "user_id";
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Page OpenPage = new Pages.Dlg.UserDlgPage( this, -1);
            DlgFrame.Navigate(OpenPage);
            Grid.SetColumnSpan(UserDataGrid, 1);
            DlgFrame.Visibility = Visibility.Visible;
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            Page OpenPage = new Pages.Dlg.UserDlgPage(this, 1);
            DlgFrame.Navigate(OpenPage);
            Grid.SetColumnSpan(UserDataGrid, 1);
            DlgFrame.Visibility = Visibility.Visible;
        }

        public void HideDlg()
        {
            DlgFrame.Navigate(null);
            DlgFrame.Visibility = Visibility.Hidden;
            Grid.SetColumnSpan(UserDataGrid, 2);
        }

    }
}
