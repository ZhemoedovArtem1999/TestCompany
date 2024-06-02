using WebApplication1.Models;

namespace WebApplication1.Repository.Interfaces
{
    public interface IResultRepository
    {
        void Insert(CreateResultModel createModel);
    }
}
