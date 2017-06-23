using System;
using XamFormsMarvel.Services;
using Foundation;
using AppKit;
using XamFormsMarvel.Mac.Services;

[assembly: Xamarin.Forms.Dependency (typeof (OpenWebService))]
namespace XamFormsMarvel.Mac.Services
{
	public class OpenWebService : IOpenWebService
	{
		public OpenWebService ()
		{
		}

		#region IOpenWebService implementation

		public void OpenUrl (string url)
		{
            NSWorkspace.SharedWorkspace.OpenUrl(new NSUrl(url));
		}

		#endregion
	}
}

