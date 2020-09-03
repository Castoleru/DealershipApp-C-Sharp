using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Masini
    {
        public int carId { get; set; }
        public String make { get; set; }
        public String model { get; set; }
        public double carPrice { get; set; }
        public int carYear { get; set; }
        public int codITP { get; set; }
        public bool isSold { get; set; }
        public List<String> URL { get; set; }
        public int HorsePower { get; set; }
        public String FuelType { get; set; }
        public String name { get; set; }
        public String color { get; set; }
        public int Co2E { get; set; }
        public String ParkingSpot { get; set; }
        public double Consumption { get; set; }
        public String Traction { get; set; }
        public double CilindricalCap { get; set; }
        public List<String> Features { get; set; }

    public Masini(int carId, String make, String model, double carPrice, int carYear, int codITP, bool isSold,List <String> URL,int HorsePower,String FuelType)
        {
            this.carId = carId;
            this.make = make;
            this.model = model;
            this.carPrice = carPrice;
            this.carYear = carYear;
            this.codITP = codITP;
            this.isSold = isSold;
            this.URL = URL;
            this.HorsePower = HorsePower;
            this.FuelType = FuelType;
            name = make +" "+ model;
        }

        public Masini(int carId, String make, String model, double carPrice,int carYear, bool isSold, List<String> URL, int HorsePower, String FuelType)
        {
            this.carId = carId;
            this.make = make;
            this.model = model;
            this.carPrice = carPrice;
            this.HorsePower = HorsePower;
            this.FuelType = FuelType;
            this.URL = URL;
            this.isSold = isSold;
            this.carYear = carYear;
            name = make + " " + model;
        }

        public Masini(Masini masina,int carYear, int codITP, bool isSold, List<String> URL)
        {
           
            this.carId =masina.carId;
            this.make = masina.make;
            this.model = masina.model;
            this.carPrice = masina.carPrice;
            this.carYear = carYear;
            this.codITP = codITP;
            this.isSold = isSold;
            this.URL = URL;
            this.HorsePower =masina.HorsePower;
            this.FuelType = masina.FuelType;
            //name = make + " " + model;
        }

        public Masini()
        {
            this.carId = new int();
            this.make = "";
            this.model = "";
            this.carPrice = new int();
            this.carYear = new int();
            this.codITP = new int();
            this.isSold = false;
            this.URL = new List<string>();
            this.HorsePower = new int();
            this.FuelType = "";
            name = make + " " + model;
            this.color = "";
            this.Consumption = new int();
            this.ParkingSpot = "";
            this.Traction = "";
            this.Features = new List<string>();
            this.CilindricalCap = new int();
        }


    }
}
