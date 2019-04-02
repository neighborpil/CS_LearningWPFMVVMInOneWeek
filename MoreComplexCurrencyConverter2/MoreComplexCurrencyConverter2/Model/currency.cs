using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreComplexCurrencyConverter2.Model
{
    public class Currency
    {
        public string Title { get; set; }
        public decimal Rate { get; set; }

        public Currency(string title, decimal rate)
        {
            Title = title ?? throw new ArgumentNullException(paramName: nameof(title));
            Rate = rate;
        }
    }
}
