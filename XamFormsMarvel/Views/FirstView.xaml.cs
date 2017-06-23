using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamFormsMarvel.ViewModels;
using Xamarin.Forms.Xaml;
using XamFormsMarvel.Renderer;
using System.Threading.Tasks;

namespace XamFormsMarvel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstView : ContentPage
    {
        private FirstViewModel _vm;

        public FirstView()
        {
			InitializeComponent();

            // Navigation to detail page
            this.listCharacters.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
                var character = (CharacterItemViewModel)e.SelectedItem;
                var detailVm = new DetailViewModel(character);

                var detailView = new DetailView(detailVm);

                this.Navigation.PushAsync(detailView);
            };

            switch(Device.RuntimePlatform)
            {
                case Device.UWP:
                    listCharacters.ItemTemplate = new DataTemplate(() =>
		            {
		                var nativeCell = new NativeCell();
		                nativeCell.SetBinding(NativeCell.NameProperty, "Name");
		                nativeCell.SetBinding(NativeCell.ThumbnailProperty, "Thumbnail");

		                return nativeCell;
		            });
                    break;
                case Device.macOS:
                    searchBar.FontSize = 14;
                    break;
            }

            _vm = new FirstViewModel();
            BindingContext = _vm;
			Task.Run(async () => await _vm.Init());
            
        }

    }
}

