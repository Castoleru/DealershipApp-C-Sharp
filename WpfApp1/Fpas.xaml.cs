using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
    /// Interaction logic for Fpas.xaml
    /// </summary>
    public partial class Fpas : Window
    {

        SqlConnection myCon = new SqlConnection();


        public Fpas()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
            if(emailTB.Text!="")
            {
                try
                {
                    List<Utilizator> utilizatori = new List<Utilizator>();
                    string body = "";
                    myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ii-proj\Developer-s-Work\WpfApp1\WpfApp1\PCDB.mdf;Integrated Security=True"; myCon.Open();
                    DataSet dataset = new DataSet();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [user]", myCon);
                    dataAdapter.Fill(dataset, "[user]");
                    foreach (DataRow dr in dataset.Tables["[user]"].Rows)
                    {
                        int admin = Convert.ToInt32(dr.ItemArray.GetValue(3).ToString());
                        String emailRead = dr.ItemArray.GetValue(1).ToString();
                        String passRead = dr.ItemArray.GetValue(2).ToString();
                        double salary = Convert.ToDouble(dr.ItemArray.GetValue(4).ToString());
                        utilizatori.Add(new Utilizator(emailRead, passRead, admin,salary));
                    }
                    myCon.Close();
                    bool ok = false;
                    foreach (Utilizator utilizator in utilizatori)
                    {
                        if (utilizator.email == emailTB.Text)
                        {
                            body = "Parola voastra este: " + utilizator.pass;
                            new MessageBoxPoni("Mail Trimis!").Show();
                            ok = true;
                        }
                    }
                    if (ok == true)
                    {
                        var fromAddress = new MailAddress("ponicarsrl@gmail.com");
                        var fromPassword = "ponicar2020";
                        var toAddress = new MailAddress(emailTB.Text);
                        string subject = "SUBIECT";
                        System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
                        {
                            Host = "smtp.gmail.com",
                            Port = 587,
                            EnableSsl = true,
                            DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
                            UseDefaultCredentials = false,
                            Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                        };
                        using (var message = new MailMessage(fromAddress, toAddress)
                        {
                            Subject = subject,
                            Body = body
                        })
                            smtp.Send(message);
                    }
                    else
                    {
                        new MessageBoxPoni("Email introdus gresit!").Show();
                    }
                }
                catch(SmtpException ex)
                {
                    Console.WriteLine(ex.Message);
                    new MessageBoxPoni("Probleme la comunicarea cu serverul!").Show();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    new MessageBoxPoni("Email introdus gresit!").Show();
                }
            }
            else
            {
                new MessageBoxPoni("Casuta goala").Show();
            }
        }

        private void Ellipse_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
