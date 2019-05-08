using System;
using System.Windows.Data;
using System.Windows;
using System.Globalization;

namespace Generator.GUI
{
    [ValueConversion(typeof(bool), typeof(Visibility))]
    public class BoolToVisibilityConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return Visibility.Collapsed;

            Visibility falseVisibility = Visibility.Collapsed;

            if (parameter != null && parameter.ToString().ToLower() == "hidden")
                falseVisibility = Visibility.Hidden;

            if (parameter != null && parameter.ToString().ToLower() == "reverse")
                return System.Convert.ToBoolean(value) ? falseVisibility : Visibility.Visible;

            return System.Convert.ToBoolean(value) ? Visibility.Visible : falseVisibility;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
