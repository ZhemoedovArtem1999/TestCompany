using WebApplication1.Models;
using WebApplication1.Repository.Filter;

namespace WebApplication1.Repository.Interfaces
{
    public interface IAnswerRepository
    {
        IEnumerable<Answer> Select(AnswerFilter answerFilter);
    }
}
