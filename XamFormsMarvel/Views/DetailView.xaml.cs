using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamFormsMarvel.ViewModels;
using Xamarin.Forms.Xaml;

namespace XamFormsMarvel.Views
{
	[XamlCompilation (XamlCompilationOptions.Compile)]
	public partial class DetailView : ContentPage
	{
        

		public DetailView (DetailViewModel detailvm)
		{
			InitializeComponent ();
			this.BindingContext = detailvm;



		}
	}
}

