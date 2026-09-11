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

                new ExamQuestion
                {
                    Id = 6,
                    QuestionText = "Where is a database connection string commonly stored in an ASP.NET Core MVC application?",
                    Options = new List<string>{ "A. Program.cs only", "B. appsettings.json", "C. Index.cshtml", "D. Student.cs" },
                    CorrectAnswer = "B",
                    Topic = "Configuration Settings",
                    Explanation = "appsettings.json is the standard configuration file for connection strings and app secrets."
                },
                new ExamQuestion
                {
                    Id = 7,
                    QuestionText = "A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?",
                    Options = new List<string>{ "A. One-to-One", "B. One-to-Many", "C. Many-to-Many", "D. Many-to-One only" },
                    CorrectAnswer = "B",
                    Topic = "Relational Relationships",
                    Explanation = "One Section maps to multiple Student records (One-to-Many)."
                },
                new ExamQuestion
                {
                    Id = 8,
                    QuestionText = "In the following example, what is SectionId? public int SectionId { get; set; } public Section Section { get; set; }",
                    Options = new List<string>{ "A. Primary key of Student", "B. Foreign key referencing Section", "C. Navigation property", "D. Database connection string" },
                    CorrectAnswer = "B",
                    Topic = "Entity Properties & Keys",
                    Explanation = "SectionId holds the key value linking the student record to its primary record in the Section table."
                },
                new ExamQuestion
                {
                    Id = 9,
                    QuestionText = "What is the purpose of a navigation property such as public Section Section { get; set; }?",
                    Options = new List<string>{ "A. It stores the database password", "B. It represents a relationship to another entity", "C. It creates a new database", "D. It validates the student's name" },
                    CorrectAnswer = "B",
                    Topic = "Navigation Properties",
                    Explanation = "Navigation properties hold references to related entity objects rather than raw scalar values."
                },
                new ExamQuestion
                {
                    Id = 10,
                    QuestionText = "What does .Include() generally allow EF Core to do?",
                    Options = new List<string>{ "A. Delete the Section table", "B. Load related Section data together with Students", "C. Create a new Student", "D. Validate Student input" },
                    CorrectAnswer = "B",
                    Topic = "Eager Loading with Include",
                    Explanation = ".Include() specifies related entities to be loaded along with the main query result (eager loading)."
                },
                new ExamQuestion
                {
                    Id = 11,
                    QuestionText = "Why might a ViewModel be used when displaying Student and Section information?",
                    Options = new List<string>{ "A. To replace the database", "B. To combine or shape the data specifically needed by the view", "C. To automatically create database tables", "D. To prevent controllers from using LINQ" },
                    CorrectAnswer = "B",
                    Topic = "ViewModels & Presentation",
                    Explanation = "ViewModels decouple UI/view requirements from entity models."
                },
                new ExamQuestion
                {
                    Id = 12,
                    QuestionText = "Consider this query: var students = _context.Students.Include(s => s.Section).ToList(); What is the main benefit of Include(s => s.Section)?",
                    Options = new List<string>{ "A. It loads the related Section navigation property", "B. It creates a Section object manually", "C. It removes the foreign key", "D. It prevents the query from accessing the database" },
                    CorrectAnswer = "A",
                    Topic = "LINQ Query Optimization",
                    Explanation = "It populates the Section navigation property directly inside the student query."
                },
                new ExamQuestion
                {
                    Id = 13,
                    QuestionText = "Which type of validation occurs in the browser before a request is sent to the server?",
                    Options = new List<string>{ "A. Database-level validation", "B. Client-side validation", "C. Server-side validation", "D. EF Core migration validation" },
                    CorrectAnswer = "B",
                    Topic = "Validation Types",
                    Explanation = "Client-side validation executes JavaScript in the browser prior to HTTP transmission."
                },
                new ExamQuestion
                {
                    Id = 14,
                    QuestionText = "Why is server-side validation still necessary if client-side validation exists?",
                    Options = new List<string>{ "A. Client-side validation can be bypassed", "B. Client-side validation automatically modifies the database", "C. Server-side validation only works with SQLite", "D. Client-side validation cannot display messages" },
                    CorrectAnswer = "A",
                    Topic = "Server-side Validation Integrity",
                    Explanation = "Client-side scripts can easily be modified or disabled by users; server-side validation guarantees security."
                },
                new ExamQuestion
                {
                    Id = 15,
                    QuestionText = "A school requires every student to have a unique Student Number. Which rule best represents this requirement?",
                    Options = new List<string>{ "A. Student Number should always be nullable", "B. Student Number should be unique", "C. Student Number should always be the same", "D. Student Number should contain only spaces" },
                    CorrectAnswer = "B",
                    Topic = "Business & Domain Rules",
                    Explanation = "Uniqueness ensures distinct identification across all student records."
                },

                new ExamQuestion
                {
                    Id = 16,
                    QuestionText = "Which is the best reason for having a database-level unique constraint on StudentNumber?",
                    Options = new List<string>{ "A. It protects data integrity even if application-level validation is bypassed", "B. It makes Razor Views render faster", "C. It removes the need for a Controller", "D. It automatically creates a ViewModel" },
                    CorrectAnswer = "A",
                    Topic = "Database Constraints",
                    Explanation = "Database constraints serve as the final line of defense for data consistency."
                },
            };
        }
    }
}