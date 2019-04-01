using BusinessLogic;
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

namespace WpfDemos
{
    /// <summary>
    /// Interaction logic for CollectionOfCars.xaml
    /// </summary>
    public partial class CollectionOfCars : Page
    {
        public CollectionOfCars()
        {
            InitializeComponent();

            var cars = new List<Car>();
            for (int i = 0; i < 10; i++)
            {
                cars.Add(new Car() {
                    Speed = i * 10,
                    Color = Colors.Red
                });
            }
            this.DataContext = cars;
        }
    }
}
