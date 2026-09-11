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

        public List<ExamQuestion> GetExamQuestions()
        {
            return new List<ExamQuestion>
            {
                new ExamQuestion
                {
                    Id = 1,
                    QuestionText = "What is the main problem solved by using a database instead of an in-memory collection?",
                    Options = new List<string>{ "A. It makes C# code shorter", "B. It prevents the application from restarting", "C. It allows data to persist after the application stops", "D. It removes the need for MVC" },
                    CorrectAnswer = "C",
                    Topic = "Relational Data Modeling",
                    Explanation = "Databases provide persistent storage, retaining data after an application halts or restarts."
                },
                new ExamQuestion
                {
                    Id = 2,
                    QuestionText = "Which approach is being used when an existing database is used to generate EF Core entity classes?",
                    Options = new List<string>{ "A. Code-First", "B. Database-First", "C. Model-First", "D. Controller-First" },
                    CorrectAnswer = "B",
                    Topic = "EF Core Approaches",
                    Explanation = "Database-First scaffolds entities directly from an existing database schema."
                },
                new ExamQuestion
                {
                    Id = 3,
                QuestionText = "What is the primary purpose of Entity Framework Core?",
                Options = new List<string>{ "A. To create HTML pages automatically", "B. To replace the MVC Controller", "C. To map objects in code to relational database data", "D. To replace the C# compiler" },
                CorrectAnswer = "C",
                Topic = "Entity Framework Core Basics",
                Explanation = "EF Core is an ORM (Object-Relational Mapper) that maps C# objects to relational database tables."
                },
                new ExamQuestion
                {
                    Id = 4,
                    QuestionText = "Which EF Core component is primarily responsible for communicating with the database?",
                    Options = new List<string>{ "A. DbContext", "B. DbSetView", "C. ControllerContext", "D. RazorContext" },
                    CorrectAnswer = "A",
                    Topic = "EF Core Components",
                    Explanation = "DbContext coordinates EF Core functionality and manages sessions with the database."
                },
                new ExamQuestion
                {
                    Id = 5,
                    QuestionText = "What does the following command primarily do? dotnet ef dbcontext scaffold \"ConnectionString\" Microsoft.EntityFrameworkCore.SqlServer -o Models",
                    Options = new List<string>{ "A. Deletes the database", "B. Creates a new MVC project", "C. Generates EF Core models and a DbContext from an existing database", "D. Starts the MVC application" },
                    CorrectAnswer = "C",
                    Topic = "EF Core Scaffolding Command",
                    Explanation = "Scaffolding reads an existing database schema and generates model classes and a DbContext file."
                },

            };
        }
    }
}