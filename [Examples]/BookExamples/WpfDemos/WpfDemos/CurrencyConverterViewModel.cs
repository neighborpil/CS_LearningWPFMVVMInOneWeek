using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDemos
{
    public class CurrencyConverterViewModel : Notifier
    {
        // Verbose code we can almost ignore
        private decimal euros;

        public decimal Euros
        {
            get { return euros; }
            set
            {
                euros = value;
                OnPropertyChanged("Euros");
                OnEurosChanged();
            }
        }

        private decimal dollars;

        public decimal Dollars
        {
            get { return dollars; }
            set
            {
                dollars = value;
                OnPropertyChanged("Dollars");
            }
        }

        // This is where the magic hapens
        private void OnEurosChanged()
        {
            Dollars = Euros * 1.1M;
        }
    }
}
