using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamFormsMarvel.ViewModels;
using Xamarin.Forms.Xaml;


namespace XamFormsMarvel.Views
{
	[XamlCompilation (XamlCompilationOptions.Compile)]
	public partial class FirstView : ContentPage
	{
		private FirstViewModel _vm;

		public FirstView ()
		{
			InitializeComponent ();
			_vm = new FirstViewModel ();

			// Navigation to detail page
			this.listCharacters.ItemSelected += (object sender, SelectedItemChangedEventArgs e) => {
				var character = (CharacterItemViewModel)e.SelectedItem;
				var detailVm = new DetailViewModel(character);

				var detailView = new DetailView(detailVm);

				this.Navigation.PushAsync(detailView);
			};

//			Label lbl = new Label ();
//			lbl.HorizontalTextAlignment = TextAlignment.Start

			BindingContext = _vm;
			_vm.LoadData();
		}


		protected override async void OnAppearing ()
		{
			base.OnAppearing ();

		}
	}
}

