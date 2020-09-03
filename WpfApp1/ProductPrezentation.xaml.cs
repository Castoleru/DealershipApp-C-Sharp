using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
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
using System.Data.SqlClient;
using System.Data;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for ProductPrezentation.xaml
    /// </summary>
    public partial class ProductPrezentation : Window
    {
        List<Image> images = new List<Image>();
        private Utilizator utilizator;
        private Masini masina;
        SqlConnection myCon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\ii-proj\Developer-s-Work\WpfApp1\WpfApp1\PCDB.mdf;Integrated Security = True");

        public ProductPrezentation(Utilizator utilizator,Masini masina)
        {

            InitializeComponent();
            myCon.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ii-proj\Developer-s-Work\WpfApp1\WpfApp1\PCDB.mdf;Integrated Security=True";
            this.utilizator = utilizator;
            this.masina = masina;
            emailTextBlock.Text = utilizator.email;
            var products = GetProducts();

            myCon.Open();
            DataSet dataset = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM [SpecificationCar]", myCon);
            dataAdapter.Fill(dataset, "[SpecificationCar]");
            foreach (DataRow dr in dataset.Tables["[SpecificationCar]"].Rows)
            {

                int carId = Convert.ToInt32(dr.ItemArray.GetValue(1).ToString());
                if (carId ==masina.carId)
                {
                    masina.color = dr.ItemArray.GetValue(2).ToString();
                    masina.Co2E= Convert.ToInt32(dr.ItemArray.GetValue(3).ToString());
                    masina.ParkingSpot= dr.ItemArray.GetValue(4).ToString();
                    masina.Consumption = Convert.ToDouble(dr.ItemArray.GetValue(5).ToString());
                    masina.Traction= dr.ItemArray.GetValue(6).ToString();
                    masina.CilindricalCap= Convert.ToDouble(dr.ItemArray.GetValue(7).ToString());
                    String[] feat= dr.ItemArray.GetValue(8).ToString().Split('@');

                    List<String> f = new List<string>();
                    for(int i = 0; i < feat.Length; i++)
                    {
                        f.Add(feat[i]);
                    }
                

                    brand.Text = brand.Text + ": "+ masina.make;
                    model.Text = model.Text + ": " + masina.model;
                    culoare.Text = culoare.Text + ": " + masina.color;
                    combustibil.Text = combustibil.Text + ": " + masina.FuelType;
                    caiputere.Text = caiputere.Text + ": " + masina.HorsePower.ToString();
                    tractiune.Text = tractiune.Text + ": " + masina.Traction;
                    capcilindrica.Text = capcilindrica.Text + ": " +  masina.CilindricalCap.ToString();
                    locparcare.Text = locparcare.Text + ": " + masina.ParkingSpot;
                    pret.Text = "$" + masina.carPrice.ToString();
                    f.RemoveAt(f.Count - 1);

                    features.Items.Clear();
                    foreach (String feature in f)
                    {
                        features.Items.Add(feature);
                    }

                }
               
            }

            products.RemoveAt(products.Count - 1);
            if (products.Count > 0)
                PhotosList.ItemsSource = products;

            try
            {
                

                var uriSource = new Uri(@"/WpfApp1;component/"+products.ElementAt(0).Image, UriKind.Relative);
                BigImg.Source = new BitmapImage(uriSource);
                BigImg.Width = 400;
                BigImg.Height = 400;

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            myCon.Close();
        }

        private void ButtonAccInfo_Click(object sender, RoutedEventArgs e)
        {
            AccInfo accInfo = new AccInfo(utilizator);
            accInfo.Show();
            this.Close();
        }

        private void ButtonLogOut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);

        }

        private void ButtonBack_Click(object sender, RoutedEventArgs e)
        {

            this.Visibility = Visibility.Hidden;
        }

        private void PhotosList_PreviewKeyUp(object sender, KeyEventArgs e)
        {

            
        }
        private void PhotosList_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {

            try
            {

                var products = GetProducts();
                var uriSource = new Uri(@"/WpfApp1;component/" + products.ElementAt(PhotosList.SelectedIndex).Image, UriKind.Relative);
                BigImg.Source = new BitmapImage(uriSource);
                BigImg.Width = 400;
                BigImg.Height = 400;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        private List<Images> GetProducts()
        {
            List<Images> images = new List<Images>();
            
            foreach(string s in masina.URL)
            {
                images.Add(new Images(s));
            }

            return images;
        }
        public Masini GetMasini()
        {
            return this.masina;
        }
 
        public Utilizator GetUtilizator()
        {
            return this.utilizator;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            utilizator.salesNumber = utilizator.salesNumber + 1;
            myCon.Open();
            SqlCommand cmd = new SqlCommand();
            try
            {
                if (utilizator.isAdmin == 1)
                {
                    cmd = new SqlCommand("UPDATE [Admin] SET SalesNumber=@SN WHERE [Email]=@Email", myCon);
                    cmd.Parameters.AddWithValue("@Email", utilizator.email);
                    cmd.Parameters.AddWithValue("@SN", utilizator.salesNumber);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd = new SqlCommand("UPDATE [Dealer] SET SalesNumber=@SN WHERE [Email]=@Email", myCon);
                    cmd.Parameters.AddWithValue("@Email", utilizator.email);
                    cmd.Parameters.AddWithValue("@SN", utilizator.salesNumber);
                    cmd.ExecuteNonQuery();
                }
               
            }catch(Exception ex)
            {
                new MessageBoxPoni("DB Error USER").Show();
                Console.WriteLine(ex.Message);
                myCon.Close();
                return;
            }

            myCon.Close();
          
            masina.isSold = true;
            myCon.Open();
            try
            {
                cmd = new SqlCommand("UPDATE [Car] SET IsSold=@IS WHERE [CarId]=@CID", myCon);
                cmd.Parameters.AddWithValue("@CID", masina.carId);
                cmd.Parameters.AddWithValue("@IS", masina.isSold);
                cmd.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                new MessageBoxPoni("DB Error CAR").Show();
                Console.WriteLine(ex.Message);
                myCon.Close();
                return;
            }
            myCon.Close();
            this.Hide();
        }
    }
}


