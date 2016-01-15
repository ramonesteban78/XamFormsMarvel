using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace XamFormsMarvel.UITests
{
	[TestFixture (Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests (Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest ()
		{
			app = AppInitializer.StartApp (platform);
		}

		[Test]
		public void NewTest ()
		{
			app.Tap(x => x.Class("Xamarin_Forms_Platform_iOS_LabelRenderer").Index(1));
			app.Screenshot("Tapped on view Xamarin_Forms_Platform_iOS_LabelRenderer");
			app.Tap(x => x.Text("Marvel Characters"));
			app.Screenshot("Tapped on view UILabel with Text: 'Marvel Characters'");
			app.Tap(x => x.ClassFull("_UISearchBarSearchFieldBackgroundView"));
			app.Screenshot("Tapped on view _UISearchBarSearchFieldBackgroundView");
			app.EnterText(x => x.Class("UISearchBarTextField"), "Thor");
			app.Screenshot("Entered 'Thor' into view UISearchBarTextField");

			app.PressEnter ();

			app.Tap(x => x.Class("Xamarin_Forms_Platform_iOS_LabelRenderer"));
			app.Screenshot("Entered 'Thor' into view UISearchBarTextField");
			app.Screenshot("Tapped on view Xamarin_Forms_Platform_iOS_LabelRenderer");
			app.Tap(x => x.Text("Marvel Characters"));
			app.Screenshot("Tapped on view UILabel with Text: 'Marvel Characters'");
		}


	}
}

