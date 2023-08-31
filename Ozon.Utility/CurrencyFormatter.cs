using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ozon.Utility
{
    public static class CurrencyFormatter
    {
        public static string FormatCurrency(double value, string cultureCode)
        {
            CultureInfo cultureInfo = new CultureInfo(cultureCode);
            return value.ToString("c", cultureInfo);
        }
    }
}
