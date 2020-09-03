using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class ViewModelFS
    {
        public List<FuelSales> fuelSales { get; set; }

        public ViewModelFS(List<FuelSales> fuelSales)
        {
            this.fuelSales = fuelSales;
        }
    }
}
