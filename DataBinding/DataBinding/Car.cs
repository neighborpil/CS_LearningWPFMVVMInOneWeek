using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DataBinding
{
    public class Car
    {
        public int Speed { get; set; }

        public Color Color { get; set; }

        public Human Driver { get; set; }
        //public string Driver { get; set; }


        public override string ToString()
        {
            return $"{Speed}, {Driver.FirstName}";
        }
    }
}
