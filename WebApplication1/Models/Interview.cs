namespace WebApplication1.Models
{
    public class Interview
    {
        public int Id { get; set; }
        public int SurveyId { get; set; }
        public string ParticipantName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
