using WebApplication1.DataBase;
using WebApplication1.Models;
using WebApplication1.Repository.Interfaces;

namespace WebApplication1.Repository
{
    public class ResultRepository : IResultRepository
    {
        private readonly ApplicationContext _context;
        public ResultRepository(ApplicationContext context)
        {
            _context = context;
        }
        public void Insert(CreateResultModel createModel)
        {
            Result entity = new Result();
            this.FillEntityFromCreateModel(entity, createModel);

            _context.Set<Result>().Add(entity);
            _context.SaveChanges();
        }

        private void FillEntityFromCreateModel(Result entity, CreateResultModel createModel)
        {
            entity.InterviewId = createModel.InterviewId;
            entity.QuestionId = createModel.QuestionId;
            entity.AnswerId = createModel.AnswerId;
        }
    }
}
