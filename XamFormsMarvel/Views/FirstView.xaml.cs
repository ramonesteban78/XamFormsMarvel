using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamFormsMarvel.ViewModels;
using Xamarin.Forms.Xaml;


namespace XamFormsMarvel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstView : ContentPage
    {
        private FirstViewModel _vm;

        public FirstView()
        {
            InitializeComponent();

            //var image = new Image()
            //{
            //    HeightRequest = 80,
            //    WidthRequest = 80
            //};
            //image.SetBinding(Image.SourceProperty, "Thumbnail");
            //var label = new Label()
            //{
            //    VerticalTextAlignment = TextAlignment.Start,
            //    HorizontalTextAlignment = TextAlignment.Start,
            //    VerticalOptions = LayoutOptions.FillAndExpand,
            //    HorizontalOptions = LayoutOptions.FillAndExpand
            //};
            //label.SetBinding(Label.TextProperty, "Name");
            //var stack = new StackLayout()
            //{
            //    Orientation = StackOrientation.Horizontal
            //};
            //stack.Children.Add(image);
            //stack.Children.Add(label);

            //var dt = new DataTemplate(() =>
            //{
            //    return new ViewCell()
            //    {
            //        View = stack
            //    };
            //});  

            var dt = new DataTemplate(typeof(ImageCell));
            dt.SetBinding(ImageCell.ImageSourceProperty, "Thumbnail");
            dt.SetBinding(ImageCell.TextProperty, "Name");

            listCharacters.ItemTemplate = dt;

            listCharacters.SetBinding(ListView.ItemsSourceProperty, new Binding("CharacterList"));

            _vm = new FirstViewModel();

            // Navigation to detail page
            this.listCharacters.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
            {
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


        protected override async void OnAppearing()
        {
            base.OnAppearing();

        }
    }
}

