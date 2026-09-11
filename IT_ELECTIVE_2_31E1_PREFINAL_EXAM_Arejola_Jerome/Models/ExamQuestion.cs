namespace PrefinalExamApp.Models
{
    public class ExamQuestion
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public List<string> Options { get; set; }
        public string CorrectAnswer { get; set; }
        public string Topic { get; set; }
        public string Explanation { get; set; }
    }
}