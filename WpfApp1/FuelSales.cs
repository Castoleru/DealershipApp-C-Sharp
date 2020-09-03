using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class FuelSales
    {
        public string type { set; get; }
        public int sales { set; get; }

        public FuelSales(string type, int sales)
        {
            this.type = type;
            this.sales = sales;
        }
            

    }
}
