using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace XamFormsMarvel.ViewModels
{
	public class ViewModelBase : INotifyPropertyChanged
	{
		public ViewModelBase ()
		{
		}

		#region INotifyPropertyChanged implementation

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, 
					new PropertyChangedEventArgs(propertyName));
		}

		#endregion

		#region IsBusy

		private bool _IsBusy;

		public bool IsBusy {
			get {
				return _IsBusy;
			}
			set {
				_IsBusy = value;
				OnPropertyChanged ("IsBusy");
			}
		}

		#endregion

		#region Title

		private string _Title;

		public string Title {
			get {
				return _Title;
			}
			set {
				_Title = value;
				OnPropertyChanged ("Title");
			}
		}

		#endregion

		//public INavigation Navigation { get; set; }
	}
}

