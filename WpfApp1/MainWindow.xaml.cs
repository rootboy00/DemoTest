using System;
using System.Collections.Generic;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlConnection DataBaseSqlConnection;

        public MainWindow()
        {
            InitializeComponent();
            DataBaseSqlConnection = new SqlConnection("data source=41-03;initial catalog=WorkDB;integrated security=True;MultipleActiveResultSets=True");
            DataBaseSqlConnection.Open();
        }

        private void PrevButton_Click(object sender, RoutedEventArgs e)
        {
            if (RootFrame.CanGoBack)
                RootFrame.GoBack();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (RootFrame.CanGoForward)
                RootFrame.GoForward();
        }

        private void CloseAllButton_Click(object sender, RoutedEventArgs e)
        {
            while (RootFrame.CanGoBack)
            {
                RootFrame.GoBack();
            }
            RootFrame.Navigate(null);
        }

        private void NewsButton_Click(object sender, RoutedEventArgs e)
        {
            Page OpenPage = new Pages.NewsPage(DataBaseSqlConnection);
            RootFrame.Navigate(OpenPage);

        }

        private void UserButton_Click(object sender, RoutedEventArgs e)
        {
            Page OpenPage = new Pages.UserPage(DataBaseSqlConnection);
            RootFrame.Navigate(OpenPage);
        }

        private void CommentsButton_Click(object sender, RoutedEventArgs e)
        {
            Page OpenPage = new Pages.CommentsPage(DataBaseSqlConnection);
            RootFrame.Navigate(OpenPage);
        }

        private void KategoryButton_Click(object sender, RoutedEventArgs e)
        {
            Page OpenPage = new Pages.KategoryPage(DataBaseSqlConnection);
            RootFrame.Navigate(OpenPage);

        }
    }
}
