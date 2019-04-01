using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace _4_8_INotifyPropertyChanged
{
    public class Car : Notifier
    {
        private double speed;
        public double Speed
        {
            get => speed;
            set
            {
                speed = value;
                OnPropertyChanged("Speed");
            }
        }
        public Color Color { get; set; }
        public Human Driver { get; set; }
    }
}
