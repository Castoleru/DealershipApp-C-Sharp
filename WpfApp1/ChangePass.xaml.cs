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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for ChangePass.xaml
    /// </summary>
    public partial class ChangePass : Window
    {
        private Utilizator utilizator;
        private SqlCommand cmd;
        private SqlConnection myCon = new SqlConnection();
        private static int count = 0;
        public ChangePass( Utilizator utilizator)
        {
            InitializeComponent();
            this.utilizator = utilizator;
        }

        private void closeButton_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
        }
        private void minButton_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;

        }

        private void closeButton_PreviewMouseUp_1(object sender, MouseButtonEventArgs e)
        {
            this.Hide();
        }

        private void ApplyChangesBT_Click(object sender, RoutedEventArgs e)
        {
            if(count > 5)
            {
                count = 0;
                Environment.Exit(1);
            }
            if(count == 4) 
            {
                new MessageBoxPoni("You have one more \n chance").Show();
            }
           

            string oldPass = oldPassTB.Password;
            string newPass = newPassTB.Password;
            
            List<Utilizator> utilizatori = new List<Utilizator>();
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ii-proj\Developer-s-Work\WpfApp1\WpfApp1\PCDB.mdf;Integrated Security=True";
            myCon.Open();
            if (oldPass == utilizator.pass)
            {
                if (newPass == newPassTB2.Password)
                {
                    cmd = new SqlCommand("UPDATE [user] SET [Password]=@Password WHERE [Email]=@Email", myCon);
                    cmd.Parameters.AddWithValue("@Email", utilizator.email);
                    cmd.Parameters.AddWithValue("@Password", newPass);
                    cmd.ExecuteNonQuery();
                    utilizator.pass = newPass;
                    
                    if(utilizator.isAdmin == 1)
                    {
                        cmd = new SqlCommand("UPDATE [Admin] SET [Password]=@Password WHERE [Email]=@Email", myCon);
                        cmd.Parameters.AddWithValue("@Email", utilizator.email);
                        cmd.Parameters.AddWithValue("@Password", newPass);
                        cmd.ExecuteNonQuery();
                    } 
                    else
                    {
                        cmd = new SqlCommand("UPDATE [Dealer] SET [Password]=@Password WHERE [Email]=@Email", myCon);
                        cmd.Parameters.AddWithValue("@Email", utilizator.email);
                        cmd.Parameters.AddWithValue("@Password", newPass);
                        cmd.ExecuteNonQuery();
                    }

                }
                else
                {
                    new MessageBoxPoni("Check again the \n new password").Show();
                    myCon.Close();
                    return;
                }
            }
            else
            {
                new MessageBoxPoni("Old password is wrong").Show();
                count++;
                myCon.Close();
                return;
            }
            myCon.Close();
            oldPassTB.Password = "";
            newPassTB.Password = "";
            newPassTB2.Password = "";
            this.Hide();
        }

        private void minButton_PreviewMouseUp_1(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;

        }
            
        public Utilizator GetUtilizator()
        {
            return utilizator;
        }
    }
}
