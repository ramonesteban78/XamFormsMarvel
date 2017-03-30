
using XamFormsMarvel.ViewModels;
using XamFormsMarvel.Services;
using Xamarin.Forms;
using System.Windows.Input;

namespace XamFormsMarvel.ViewModels
{
	public class DetailViewModel : BaseViewModel
	{
		private readonly IOpenWebService _openWebService;

		public DetailViewModel (CharacterItemViewModel character, IOpenWebService openWebService = null)
		{
			Character = character;
			_openWebService = openWebService ?? DependencyService.Get<IOpenWebService>();
		}

		#region Character

		private CharacterItemViewModel _Character;

		public CharacterItemViewModel Character {
			get {
				return _Character;
			}
			set {
				_Character = value;
				RaisePropertyChanged();
			}
		}

		#endregion

		#region OpenWeb Command

		private ICommand _OpenWeb;

		public ICommand OpenWeb {
			get {
				return _OpenWeb ?? (_OpenWeb = new Command (
					ExecuteOpenWebCommand,
					ValidateOpenWebCommand)); 
			}
		}

		private void ExecuteOpenWebCommand ()
		{
			_openWebService.OpenUrl (Character.Thumbnail);
		}

		private bool ValidateOpenWebCommand ()
		{
			return true;
		}

		#endregion

	}
}

