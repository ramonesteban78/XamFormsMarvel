using System;
using System.Globalization;
using Xamarin.Forms;

namespace XamFormsMarvel.Converters
{
	public class DescriptionToImageValueConverter : IValueConverter
	{
		public DescriptionToImageValueConverter()
		{
		}

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			string strValue = value?.ToString();

			if (string.IsNullOrEmpty(strValue))
			{
				return ImageSource.FromFile("wrong.png");
			}
			else
			{
				return ImageSource.FromFile("ok.png");
			}
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return null;
		}
	}
}
