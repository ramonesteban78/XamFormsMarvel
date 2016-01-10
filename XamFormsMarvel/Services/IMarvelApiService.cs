
using System.Threading.Tasks;
using XamFormsMarvel.Models;

namespace XamFormsMarvel.Services
{
	public interface IMarvelApiService
	{
		Task<MarvelApiData<Characters>> GetCharacters (string filter = null, int limit = 0, int offset = 0);
	}
}

