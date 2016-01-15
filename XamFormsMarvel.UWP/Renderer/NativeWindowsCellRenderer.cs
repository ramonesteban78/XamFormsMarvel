using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using XamFormsMarvel.Renderer;
using XamFormsMarvel.UWP.Renderer;



[assembly: ExportRenderer(typeof(NativeCell), typeof(NativeWindowsCellRenderer))]
namespace XamFormsMarvel.UWP.Renderer
{
    public class NativeWindowsCellRenderer : ViewCellRenderer
    {
        public override Windows.UI.Xaml.DataTemplate GetTemplate(Cell cell)
        {
            return App.Current.Resources["ListViewItemTemplate"] as Windows.UI.Xaml.DataTemplate;
        }
    }

}
