using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoreComplexCurrencyConverter2.Model;

namespace MoreComplexCurrencyConverter2.ViewModel
{
    public class CurrencyConverterViewModel : Notifier
    {
        private decimal euros;
        public decimal Euros
        {
            get => euros;
            set
            {
                euros = value;
                OnPropertyChanged("Euros");
                OnEuroChanged();
            }
        }

        private decimal converted;
        public decimal Converted
        {
            get => converted;
            set
            {
                converted = value;
                OnPropertyChanged("Converted");
            }
        }

        private Currency selectedCurrency;
        public Currency SelectedCurrency
        {
            get => selectedCurrency;
            set
            {
                selectedCurrency = value;
                OnPropertyChanged("SelectedCurrency");
                OnSelectedCurrencyChanged();
            }
        }

        private IEnumerable<Currency> currencies;
        public IEnumerable<Currency> Currencies
        {
            get => currencies;
            set
            {
                currencies = value;
                OnPropertyChanged("Currencies");
            }
        }

        private string resultText;

        public string ResultText
        {
            get => resultText;
            set
            {
                resultText = value;
                OnPropertyChanged("ResultText");
            }
        }

        public CurrencyConverterViewModel()
        {
            Currencies = new Currency[]
            {
                new Currency("US Dollar", 1.1M),
                new Currency("British Pound", .9M) 
            };
        }

        private void OnEuroChanged()
        {
            ComputeConverted();
        }

        private void OnSelectedCurrencyChanged()
        {
            ComputeConverted();
        }

        private void ComputeConverted()
        {
            Converted = selectedCurrency.Rate * Euros;
            ResultText = $"Amount in {selectedCurrency.Title}";
        }
    }
}
