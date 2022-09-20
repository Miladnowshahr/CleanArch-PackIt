
namespace PackIt.Application.Service
{
    public interface IPackingListReadService
    {

        Task<bool> ExistsByNameAsync(string name);
    }
}
