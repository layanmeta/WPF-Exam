using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace WPFExam1
{
    class somethingblabla : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (parameter == null) return "ButtonSize";

            var sliderObject = (Slider)parameter;
            double minimum = sliderObject.Minimum;
            double maximum = sliderObject.Maximum;            

            var range = maximum - minimum;
            double fixedValue = (double)value - minimum;

            var percentage = (fixedValue * 100) / range;

            if (percentage <=  25)
            {
                return "small";
            }
            else if (percentage > 25 && percentage <= 50)
            {
                return "Medium";
            }
            else if (percentage > 50 && percentage <=75)
            {
                return "large";
            }
            return "Extra large";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
