using AiOpenMath.Domain;
using AiOpenMath.Domain.MyOwnTimerBecauseDotNetsCrappyTimerWontWork;
using AiOpenMath.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AiOpenMath.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // GET: HomeWork
        private static IList<string> questions;
        private static IList<string> answers;
        private int homeworkID;
        public ActionResult index()
        {





            var allQuestions = "";
            var allAnswers = "";


            homeworkID = 1;
            questions = new List<string>();
            answers = new List<string>();
            var parameter = new HomeworkParameters();
            var noOfQuestions = 5; // number of questions
            parameter.ComplexityID = 2;
            parameter.NoOfTerms = 3;
            parameter.NoOfLawsInUse = 2;
            parameter.DegreeOfRemoval = 2;
            parameter.AngleOrSide = 1;
            parameter.ArithOrGeom = 1;
            parameter.HighestNumber = 15;
            parameter.HighestNumberPow = 2;
            parameter.highest_a = 2;
            parameter.highest_d = 5;
            parameter.highest_n = 1000;
            parameter.highest_r = 2;
            parameter.maxSides = 2;
            parameter.NoOfTerms = 2;

            for (int i = 0; i < noOfQuestions; i++)
            {
                var function = Gr12Wrapper
                .GetSubSyllabusQuestionGenerator(4); // SubSyllabusID
                var temp = function.Invoke(parameter);
                allQuestions += temp.Split('$')[0] + "$";
                allAnswers += temp.Split('$')[1] + "$";
                questions.Add(temp.Split('$')[0]);
                answers.Add("");//temp.Split('$')[1]);
                function = null;
                MyTimer.IntervalTimer_Elapsed(0.5m);
            }

            var viewModel = new QuestionsViewModel();
            viewModel.questions = questions;
            viewModel.answers = answers;
            viewModel.preview = false;

            viewModel.HomeWorkID = homeworkID;


            return View(viewModel);
        }

        [HttpPost]
        public ActionResult index(QuestionsViewModel model)
        {
            var answers = model.answers;
            var answersString = "";

            foreach (var answer in answers)
            {
                answersString += answer + "$";
            }
            return View();
        }
    }
}