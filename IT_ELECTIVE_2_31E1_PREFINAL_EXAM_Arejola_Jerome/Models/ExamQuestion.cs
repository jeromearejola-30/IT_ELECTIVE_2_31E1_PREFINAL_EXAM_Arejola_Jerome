namespace PrefinalExamApp.Models
{
    public class ExamQuestion
    {
        public int Id { get; set; }
        public string QuestionText { get; set; } = string.Empty;
        public List<string> Options { get; set; } = new List<string>();
        public string CorrectAnswer { get; set; } = string.Empty;
        public string Topic { get; set; } = string.Empty;
        public string Explanation { get; set; } = string.Empty;
    }
}