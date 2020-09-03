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
    /// Interaction logic for AccInfo.xaml
    /// </summary>
    public partial class AccInfo : Window
    {

        private Utilizator utilizator;
        public AccInfo(Utilizator utilizator)
        {
            InitializeComponent();
            this.utilizator = utilizator;
            emailTB.Text = utilizator.email;
            numeTB.Text = utilizator.nume;
            prenumeTB.Text = utilizator.prenume;
            salesTB.Text = "" + utilizator.salesNumber;
            salaryTB.Text = "" + utilizator.salary;
        }


        private void Close_Click(object sender, RoutedEventArgs e)
        {
            UserMenu user = new UserMenu(utilizator);
            user.Show();
            this.Close();

        }

        private void ChangePB_Click(object sender, RoutedEventArgs e)
        {
            ChangePass changePass = new ChangePass(utilizator);
            changePass.ShowDialog();
            this.utilizator = changePass.GetUtilizator();
            changePass.Close();

        }
    }
}
