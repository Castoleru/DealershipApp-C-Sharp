using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Utilizator
    {
        public string email { get; set; }
        public string pass { get; set; }
        public int isAdmin { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public int salesNumber { get; set; }
        public double salary { get; set; }

        public Utilizator(string email, string pass, int isAdmin, double slary)
        {
            this.email = email;
            this.pass = pass;
            this.isAdmin = isAdmin;
            this.nume = "";
            this.prenume = "";
            this.salesNumber = 0;
            this.salary = slary;
        }
        public Utilizator(string email, string pass, int isAdmin, string nume, string prenume)
        {
            this.email = email;
            this.pass = pass;
            this.isAdmin = isAdmin;
            this.nume = nume;
            this.prenume = prenume;
            this.salesNumber = 0;

        }
        public Utilizator(string email, string pass, int isAdmin, string nume, string prenume,int sales)
        {
            this.email = email;
            this.pass = pass;
            this.isAdmin = isAdmin;
            this.nume = nume;
            this.prenume = prenume;
            this.salesNumber = sales;

        }

        public Utilizator()
        {

        }


    }
}
