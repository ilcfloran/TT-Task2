using System.Threading.Tasks;

namespace ContactAPILibrary.Interfaces
{
    public interface IFullContactApi
    {
        Task<Models.Models.FullContactPerson> LookupPersonByEmailAsync(string email);
    }
}
