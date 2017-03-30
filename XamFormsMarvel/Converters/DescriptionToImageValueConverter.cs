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
				return ImageSource.FromFile("wrong");
			}
			else
			{
				return ImageSource.FromFile("ok");
			}
				
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
