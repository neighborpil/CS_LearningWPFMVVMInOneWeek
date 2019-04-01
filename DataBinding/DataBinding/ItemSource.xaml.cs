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

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for ItemSource.xaml
    /// </summary>
    public partial class ItemSource : Page
    {
        public ItemSource()
        {
            InitializeComponent();

            var cars = new List<Car>();
            for (int i = 0; i < 10; i++)
            {
                cars.Add(new Car()
                {
                    Speed = i * 10,
                    Driver = new Human()
                    {
                        FirstName = $"Driver{i}",
                        HasDrivingLicense = new Random(DateTime.Now.Millisecond).Next(0, 1) > 0.5 ? true : false
                    }
                });
            }

            this.DataContext = cars; // 이거로 바인딩한다. 쉽게 되네, 근데 여러개 바인딩하려면 어떻게?
        }
    }
}
