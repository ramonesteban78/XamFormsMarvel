using System;
using Xamarin.Forms;
using XamFormsMarvel.Controls;
using XamFormsMarvel.iOS.Renderers;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ImageCircle), typeof(ImageCircleRenderer))]
namespace XamFormsMarvel.iOS.Renderers
{
	public class ImageCircleRenderer : ImageRenderer
	{
		protected override void OnElementChanged (ElementChangedEventArgs<Image> e)
		{
			base.OnElementChanged (e);

			double min = Math.Min(Element.Width, Element.Height);

			Control.Layer.CornerRadius = (float)(min/2.0);
			Control.Layer.MasksToBounds = false;
			Control.ClipsToBounds = true;
		}
	}
}

