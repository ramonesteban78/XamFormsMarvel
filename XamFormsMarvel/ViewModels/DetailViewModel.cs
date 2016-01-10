
using XamFormsMarvel.ViewModels;

namespace XamFormsMarvel.ViewModels
{
	public class DetailViewModel : ViewModelBase
	{
		public DetailViewModel (CharacterItemViewModel character)
		{
			Character = character;
		}

		#region Character

		private CharacterItemViewModel _Character;

		public CharacterItemViewModel Character {
			get {
				return _Character;
			}
			set {
				_Character = value;
				OnPropertyChanged ("Character");
			}
		}

		#endregion

	}
}

