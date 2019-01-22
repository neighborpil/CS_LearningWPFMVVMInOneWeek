using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfBasicControlApp1
{
    public class Human
    {
        public string FirstName { get; set; }
        public bool HasDrivingLicense { get; set; }
    }


    public class Car
    {
        public double Speed { get; set; }
        public Color Color { get; set; }
        public Human Driver { get; set; }
    }

    /// <summary>
    /// BusinessLogic.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class BusinessLogic : Page
    {
        public BusinessLogic()
        {
            InitializeComponent();

            var h = new Human();
            h.FirstName = "Nick";
            h.HasDrivingLicense = true;

            var c = new Car();
            c.Color = Colors.Red;
            c.Driver = h;

        }
    }
}
