using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Service.Interfaces;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        private readonly IQuestionService _questionService;
        private readonly IResultService _resultService;
        public SurveyController(IQuestionService questionService, IResultService resultService)
        {
            _questionService = questionService;
            _resultService = resultService;
        }

        [HttpGet]
        [Route("/question/get")]
        public IActionResult Get(int questionId)
        {
            try
            {
                var question = _questionService.GetQuestion(questionId);

                // костыль, так как реализация неполная, то передаю id интервью
                question.InterviewId = 1;

                return Ok(question);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        [HttpPost]
        [Route("/result/save")]
        public IActionResult SaveResult(CreateResultModel createModel)
        {
            try
            {
                _resultService.SaveResult(createModel);

                int? nextQuestionId = _questionService.GetIdNewQuestion(createModel.QuestionId);

                return Ok(new { NextQuestionId = nextQuestionId, InterviewId = createModel.InterviewId });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
