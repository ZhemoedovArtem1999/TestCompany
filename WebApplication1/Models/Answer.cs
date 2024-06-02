using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("answer")]
    public class Answer
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("question_id")] 
        public int QuestionId { get; set; }
        [Column("text")] 
        public string Text { get; set; }
    }
}
