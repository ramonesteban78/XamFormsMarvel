using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamFormsMarvel.Renderer
{
    public class NativeCell : ViewCell
    {
        public static readonly BindableProperty NameProperty =
          BindableProperty.Create("Name", typeof(string), typeof(NativeCell), "");

        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        public static readonly BindableProperty ThumbnailProperty =
          BindableProperty.Create("Thumbnail", typeof(string), typeof(NativeCell), "");

        public string Thumbnail
        {
            get { return (string)GetValue(ThumbnailProperty); }
            set { SetValue(ThumbnailProperty, value); }
        }
    }
}
