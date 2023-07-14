using AiOpenMath.Domain;
using AiOpenMath.Domain.MyOwnTimerBecauseDotNetsCrappyTimerWontWork;
using AiOpenMath.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.Extensions.Configuration;

namespace AiOpenMath.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
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
            parameter.ComplexityID = _configuration.GetValue<int>("ComplexityID"); 
            parameter.NoOfTerms = _configuration.GetValue<int>("NoOfTerms");
            parameter.NoOfLawsInUse = _configuration.GetValue<int>("NoOfLawsInUse");
            parameter.DegreeOfRemoval = _configuration.GetValue<int>("DegreeOfRemoval");
            parameter.AngleOrSide = _configuration.GetValue<int>("AngleOrSide");
            parameter.ArithOrGeom = _configuration.GetValue<int>("ArithOrGeom");
            parameter.HighestNumber = _configuration.GetValue<int>("HighestNumber");
            parameter.HighestNumberPow = _configuration.GetValue<int>("HighestNumberPow");
            parameter.highest_a = _configuration.GetValue<int>("highest_a");
            parameter.highest_d = _configuration.GetValue<int>("highest_d");
            parameter.highest_n = _configuration.GetValue<int>("highest_n");
            parameter.highest_r = _configuration.GetValue<int>("highest_r");
            parameter.maxSides = _configuration.GetValue<int>("maxSides");

            for (int i = 0; i < noOfQuestions; i++)
            {
                var function = Gr12Wrapper
                .GetSubSyllabusQuestionGenerator(14); // SubSyllabusID
                var temp = function.Invoke(parameter);
                allQuestions += temp.Split('$')[0] + "$";
                allAnswers += temp.Split('$')[1] + "$";
                questions.Add(temp.Split('$')[0]);
                answers.Add(temp.Split('$')[1]);
                function = null;
                MyTimer.IntervalTimer_Elapsed(0.5m);
            }

            var viewModel = new QuestionsViewModel();
            viewModel.questions = questions;
            viewModel.answers = answers;
            viewModel.allAnswers = answers;
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