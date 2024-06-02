using WebApplication1.DataBase;
using WebApplication1.Models;
using WebApplication1.Repository.Filter;
using WebApplication1.Repository.Interfaces;

namespace WebApplication1.Repository
{
    public class AnswerRepository : IAnswerRepository
    {
        private readonly ApplicationContext _context;
        public AnswerRepository(ApplicationContext context) {
            _context = context;
        }

        public IEnumerable<Answer> Select(AnswerFilter answerFilter)
        {
            var items = _context.Answers.ToList();
            return this.ApplyFilter(items, answerFilter);
            
        }

        private IEnumerable<Answer> ApplyFilter(List<Answer> items, AnswerFilter filter)
        {
            return items.Where(x => x.QuestionId == filter.QuestionId);
        }
    }
}
