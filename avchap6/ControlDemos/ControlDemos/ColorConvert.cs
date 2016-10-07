using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Data;
using System.Windows.Media;

namespace ControlDemos
{
    class ColorConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Color theColor = new Color();
            double theValue = (double)value;
            if (theValue > 50)
            {
                theColor = Colors.Red;
            }
            else
            {
                theColor = Colors.Black;
            }
                
            return new SolidColorBrush(theColor);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }

    }
}
