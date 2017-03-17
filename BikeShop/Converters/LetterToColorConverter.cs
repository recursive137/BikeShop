using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Data;

namespace BikeShop.Converters
{
    enum Colors
    {
        r,
        g,
        b
    }

    public class LetterToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string colorLetter = value as string;
            if (colorLetter != null)
            {
                if (colorLetter.Length > 0)
                {
                    switch (colorLetter.ToLower().ElementAt(0))
                    {
                        case 'r': return "Red";
                        case 'g': return "Green";
                        case 'b': return "Black";
                        default: return "Blue";
                    }
                }
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}


