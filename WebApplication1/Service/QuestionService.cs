using WebApplication1.Models;
using WebApplication1.Repository.Filter;
using WebApplication1.Repository.Interfaces;
using WebApplication1.Service.Interfaces;

namespace WebApplication1.Service
{
    public class QuestionService: IQuestionService 
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IAnswerRepository _answerRepository;
        public QuestionService(IQuestionRepository questionRepository
                             , IAnswerRepository answerRepository) {
            _questionRepository = questionRepository;
            _answerRepository = answerRepository;
        }

      

        public QuestionViewModel GetQuestion(int questionId)
        {
            QuestionViewModel model = new QuestionViewModel();

            var question = _questionRepository.Get(questionId);
            if (question == null)
            {
                throw new Exception();
            }
            model.Question = question;

            model.Answers = _answerRepository.Select(new AnswerFilter() { QuestionId = questionId }).ToList();
            return model;
        }

        public int? GetIdNewQuestion(int questionId)
        {
            return _questionRepository.Get(questionId).NextQuestionId;
        }

    }
}
