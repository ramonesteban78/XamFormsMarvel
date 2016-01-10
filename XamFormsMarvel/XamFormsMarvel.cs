using System;

using Xamarin.Forms;
using XamFormsMarvel.Services;
using XamFormsMarvel.ViewModels;
using XamFormsMarvel.Views;

namespace XamFormsMarvel
{
	public class App : Application
	{
		public App ()
		{
			// Register our Services
			DependencyService.Register<IMarvelApiService, MarvelApiService> ();

			// The root page of your application
			MainPage = new NavigationPage(new FirstView());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

