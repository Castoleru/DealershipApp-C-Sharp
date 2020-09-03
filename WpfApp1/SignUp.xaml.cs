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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        private SqlCommand cmd;
        private SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ii-proj\Developer-s-Work\WpfApp1\WpfApp1\PCDB.mdf;Integrated Security=True");


        Utilizator utilizator;
        public SignUp(Utilizator utilizator)
        {
            InitializeComponent();
            this.utilizator = utilizator;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (emailTB.Text == "" || PassP.Password == "" || SallaryTB.Text == "" || FirstNameTB.Text == "" || LastNameTB.Text == "")
            {
                new MessageBoxPoni("All Blocks must be completed").Show();
                return;
            }
            try
            {
                try
                {
                    double salaryTest = Convert.ToDouble(SallaryTB.Text);
                }catch(Exception ex)
                {
                    Console.WriteLine(ex);
                    new MessageBoxPoni("The salary is a number");
                    return;
                }

                myCon.Open();
                cmd = new SqlCommand("INSERT INTO [user] (Email,[Password],Salary) VALUES (@Email,@Password,@Salary) ", myCon);
                cmd.Parameters.AddWithValue("@Email", emailTB.Text);
                cmd.Parameters.AddWithValue("@Password", PassP.Password);
                cmd.Parameters.AddWithValue("@Salary", SallaryTB.Text);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("INSERT INTO [Dealer] (FirstName,LastName,Email,[Password]) VALUES (@FirstName,@LastName,@email,@Password) ", myCon);
                cmd.Parameters.AddWithValue("@FirstName", FirstNameTB.Text);
                cmd.Parameters.AddWithValue("@LastName", LastNameTB.Text);
                cmd.Parameters.AddWithValue("@Email", emailTB.Text);
                cmd.Parameters.AddWithValue("@Password", PassP.Password);
                cmd.ExecuteNonQuery();
                double salary = Convert.ToDouble(SallaryTB.Text);
                utilizator = new Utilizator(emailTB.Text, PassP.Password, 0,salary);
                utilizator.nume = LastNameTB.Text;
                utilizator.prenume = FirstNameTB.Text;
                utilizator.salesNumber = 0;
                

            }
            catch (Exception ex)
            {
                new MessageBoxPoni("Data Base Error").Show();
                Console.WriteLine(ex.Message);
                myCon.Close();
                return;

            }
            myCon.Close();
            this.Hide();
        }
        public Utilizator getUtil()
        {
            return utilizator;
        }
        private void loginTBlock_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void Ellipse_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Window_Closed(object sender, EventArgs e)
        {

        }
    }
}
