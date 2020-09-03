using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Images
    {
       
        public string Image { get; set; }

        public Images( string image)
        {
            
            Image = image;
        }
        private string toString()
        {
            return Image;
        }
    }
}
