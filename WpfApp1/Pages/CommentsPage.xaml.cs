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
    /// Interaction logic for CommentsPage.xaml
    /// </summary>
    public partial class CommentsPage : Page
    {
        private SqlConnection DataBaseSqlConnection;
        private DataSet WorkDataSet;
        public CommentsPage(SqlConnection DataBaseSqlConnection)
        {
            InitializeComponent();
            this.DataBaseSqlConnection = DataBaseSqlConnection;
            WorkDataSet = new DataSet();
            UpdateDataGrid();
        }

        public void UpdateDataGrid()
        {

            //[comment_id]
            //[news_id]
            //[text_comment]
            //[date_make]
            //[date_update]
            //[user_id]

            String S = "Select c.comment_id, n.header_char, c.text_comment, c.date_make, c.date_update, u.login " +
                       "from comments c " +
                       "inner join users u on (u.user_id = c.user_id) " +
                       "inner join news n on ( n.news_id = c.news_id )  ";
            SqlDataAdapter DataAdapter = new SqlDataAdapter(S, DataBaseSqlConnection);
            WorkDataSet.Clear();
            DataAdapter.Fill(WorkDataSet);
            CommentsDataGrid.DataContext = WorkDataSet.Tables[0];
            CommentsDataGrid.SelectedValuePath = "comment_id";
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Page OpenPage = new Pages.Dlg.CommentsDlgPage( this, -1);
            DlgFrame.Navigate(OpenPage);
            Grid.SetColumnSpan(CommentsDataGrid, 1);
            DlgFrame.Visibility = Visibility.Visible;
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            Page OpenPage = new Pages.Dlg.CommentsDlgPage(this, 1);
            DlgFrame.Navigate(OpenPage);
            Grid.SetColumnSpan(CommentsDataGrid, 1);
            DlgFrame.Visibility = Visibility.Visible;
        }

        public void HideDlg()
        {
            DlgFrame.Navigate(null);
            DlgFrame.Visibility = Visibility.Hidden;
            Grid.SetColumnSpan(CommentsDataGrid, 2);
        }

    }
}
