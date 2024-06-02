using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("question")]
    public class Question
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("survey_id")]
        public int SurveyId { get; set; }
        [Column("text")]
        public string Text { get; set; }
        [Column("type")]
        public string Type { get; set; }
        [Column("nextquestionid")]
        public int? NextQuestionId { get; set; }
    }
}
