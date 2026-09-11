using Microsoft.AspNetCore.Mvc;
using PrefinalExamApp.Models;
using System.Collections.Generic;

namespace PrefinalExamApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var questions = GetExamQuestions();
            return View(questions);
        }

        private List<ExamQuestion> GetExamQuestions()
        {
            return new List<ExamQuestion>
            {
                new ExamQuestion { Id = 1, QuestionText = "What is the main problem solved by using a database instead of an in-memory collection?", Options = new List<string>{ "A. It makes C# code shorter", "B. It prevents the application from restarting", "C. It allows data to persist after the application stops", "D. It removes the need for MVC" }, CorrectAnswer = "C", Topic = "Relational Data Modeling", Explanation = "Databases provide persistent storage, retaining data after an application halts or restarts." },
                
                
            };
        }
    }
}