using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_WPF
{
    class Car
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }

        public override string ToString()
        {
            return $"Car Name: {Name}\nColor: {Color}\nBrand: {Brand}";
        }

    }
}
