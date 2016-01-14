using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamFormsMarvel.Services;
using XamFormsMarvel.Views;

namespace XamFormsMarvel
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent (); 

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

