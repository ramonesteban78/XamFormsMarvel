using System;
using Xamarin.Forms;
using System.Windows.Input;

namespace XamFormsMarvel.Controls
{
	public class CustomListView : ListView
	{
		public CustomListView ()
		{
			this.ItemTapped += this.OnItemTapped;
		}

		public static readonly BindableProperty ItemClickCommandProperty =
			BindableProperty.Create<CustomListView, ICommand> (
				p => p.ItemClickCommand, default(ICommand));

		public ICommand ItemClickCommand {
			get { return (ICommand)GetValue (ItemClickCommandProperty); }
			set { SetValue (ItemClickCommandProperty, value); }
		}



		private void OnItemTapped(object sender, ItemTappedEventArgs e)
		{
			if (e.Item != null && this.ItemClickCommand != null && this.ItemClickCommand.CanExecute(e))
			{
				this.ItemClickCommand.Execute(e.Item);
			}

			this.SelectedItem = null;
		}

	}
}

