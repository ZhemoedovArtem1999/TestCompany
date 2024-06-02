using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("result")]
    public class Result
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("interview_id")]
        public int InterviewId { get; set; }
        [Column("question_id")]
        public int QuestionId { get; set; }
        [Column("answer_id")]
        public int AnswerId { get; set; }
    }
}
