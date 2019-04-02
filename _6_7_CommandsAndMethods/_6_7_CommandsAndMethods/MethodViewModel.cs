using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _6_7_CommandsAndMethods
{
    public class MethodViewModel : Notifier
    {
        public void LoadMoreHotelsAction()
        {
            MessageBox.Show("Clicked");
        }
    }
}
