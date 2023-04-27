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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=localhost\SQLEXPRESS; Initial Catalog=Pisatelnitsa; Integrated Security=True");
            try
            {
                sqlCon.Open();
                string query = "Insert into Data (FirstName, LastName, Email, Password) values ('" + this.firstName.Text + "','" + this.lastName.Text + "', '" + this.Email.Text + "','" + this.passwordbox.Password + "')";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully created an account!");
                Window3 w3 = new Window3();
                w3.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MainWindow w0 = new MainWindow();
            w0.Show();
            this.Close();
        }
    }
}
