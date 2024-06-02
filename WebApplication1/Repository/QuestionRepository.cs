using WebApplication1.DataBase;
using WebApplication1.Models;
using WebApplication1.Repository.Interfaces;

namespace WebApplication1.Repository
{
    public class QuestionRepository : IQuestionRepository
    {
        private ApplicationContext _context;

        public QuestionRepository(ApplicationContext context)
        {
            _context = context;
        }

        public Question Get(int id)
        {
            return _context.Questions.FirstOrDefault(x => x.Id == id);
        }
    }
}
