using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.ViewModel
{
    public class ConverterViewModel : Notifier
    {
        private decimal euros;
        public decimal Euros
        {
            get => euros;
            set
            {
                euros = value;
                OnEuroChanged();
                OnPropertyChanged("Euros");
            }
        }

        private void OnEuroChanged()
        {
            Dollars = Euros * 1.1M;
        }

        private decimal dollars;

        public decimal Dollars
        {
            get => dollars;
            set
            {
                dollars = value;
                OnPropertyChanged("Dollars");
            }
        }
    }
}
