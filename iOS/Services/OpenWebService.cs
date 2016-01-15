using System;
using XamFormsMarvel.Services;
using XamFormsMarvel.iOS.Services;
using UIKit;
using Foundation;

[assembly: Xamarin.Forms.Dependency (typeof (OpenWebService))]
namespace XamFormsMarvel.iOS.Services
{
	public class OpenWebService : IOpenWebService
	{
		public OpenWebService ()
		{
		}

		#region IOpenWebService implementation

		public void OpenUrl (string url)
		{
			UIApplication.SharedApplication.OpenUrl(new NSUrl(url));
		}

		#endregion
	}
}

