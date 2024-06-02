namespace WebApplication1.Models
{
    public class QuestionViewModel
    {
        public int InterviewId { get; set; }
        public Question Question { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
