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

namespace _3_10_Event
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Greet(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello");
            Console.WriteLine("Hello");
        }

        private void SaySomething(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("SaySomething");
            Console.WriteLine("SaySomething");
        }

        private void SayHello(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("SayHello");
            Console.WriteLine("SayHello");
        }

        private void SayGoodBye(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Goodbye");
            Console.WriteLine("Goodbye");
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Entered");

        }

        private void Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Goodbye");

        }

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Goodbye");
        }

        private void Button_MouseDown2(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Goodbye2");
        }

        private void Button_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Goodbye2");

        }

        private void Button_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("double click");

        }

        private void Button_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {

                MessageBox.Show("mouse down");
            }

            e.Handled = true;

        }

        private void Button_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("mouse down");

            e.Handled = true;

        }

        private void Button_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("preview mouse down");

        }
    }
}
