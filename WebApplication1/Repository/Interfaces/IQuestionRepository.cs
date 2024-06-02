using WebApplication1.Models;

namespace WebApplication1.Repository.Interfaces
{
    public interface IQuestionRepository
    {
        Question Get(int id);
    }
}
