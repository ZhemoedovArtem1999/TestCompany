using WebApplication1.Models;

namespace WebApplication1.Service.Interfaces
{
    public interface IQuestionService
    {
        QuestionViewModel GetQuestion(int questionId);

        int? GetIdNewQuestion(int questionId);
    }
}
