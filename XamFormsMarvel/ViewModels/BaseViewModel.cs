using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace XamFormsMarvel.ViewModels
{
	public class BaseViewModel : INotifyPropertyChanged
	{
		public BaseViewModel ()
		{
		}

		#region INotifyPropertyChanged implementation

		public event PropertyChangedEventHandler PropertyChanged;

		protected void RaisePropertyChanged([CallerMemberName] string propertyName = null)
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
				RaisePropertyChanged();
			}
		}

		#endregion

		#region Title

		private readonly string _Title2;
		public string Title2 => _Title2;

		private string _Title;

		public string Title {
			get {
				return _Title;
			}
			set {
				_Title = value;
				RaisePropertyChanged();
			}
		}

		#endregion

		//public INavigation Navigation { get; set; }
	}
}

