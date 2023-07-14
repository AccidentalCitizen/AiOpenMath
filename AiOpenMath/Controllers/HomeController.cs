using AiOpenMath.Domain;
using AiOpenMath.Domain.MyOwnTimerBecauseDotNetsCrappyTimerWontWork;
using AiOpenMath.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.Extensions.Configuration;
using AiOpenMath.Domain.Basic;

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
        private readonly IList<Pair<int, string>> syllabusList = new List<Pair<int, string>>()
            {
                new Pair<int,string>(1,"BasicTrigGen"),
                new Pair<int,string>(2,"Integration by Parts"),
                new Pair<int,string>(3,"SequenceSeries"),
                new Pair<int,string>(4,"TrigProblems"),
                new Pair<int,string>(5,"TrigEqGen"),
                new Pair<int,string>(6,"Cubic"),
                new Pair<int,string>(7,"LinearProgramming"),
                new Pair<int,string>(8,"LineGraph"),
                new Pair<int,string>(9,"Differentiation"),
                new Pair<int,string>(10,"LogEquations"),
                new Pair<int,string>(13,"2D Integration"),
                new Pair<int,string>(14,"2D Jacobian Integration"),
                new Pair<int,string>(15,"Line Integration"),
                new Pair<int,string>(16,"Laplace Differential Equations"),
                new Pair<int,string>(17,"Leibniz Differential Equations")
            };
        private int homeworkID;
        public ActionResult index()
        {

            var allQuestions = "";
            var allAnswers = "";

            homeworkID = 1;
            questions = new List<string>();
            answers = new List<string>();
            HomeworkParameters parameter;
            int noOfQuestions;
            AssignParametersFromConfig(out parameter, out noOfQuestions);

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
            viewModel.allSyllabusTiems = syllabusList;
            viewModel.HomeWorkID = homeworkID;


            return View(viewModel);
        }

        private void AssignParametersFromConfig(out HomeworkParameters parameter, out int noOfQuestions)
        {
            parameter = new HomeworkParameters();
            noOfQuestions = 5;
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
        }
        [HttpPost]
        public ActionResult index(QuestionsViewModel model)
        {
            var allQuestions = "";
            var allAnswers = "";
            var oldModel = model;
            var viewModel = new QuestionsViewModel() ;


            homeworkID = 1;
            questions = new List<string>();
            answers = new List<string>();
            HomeworkParameters parameter;
            int noOfQuestions;
            AssignParametersFromConfig(out parameter, out noOfQuestions);
            viewModel.noOfQuestiones = oldModel.noOfQuestiones;
            viewModel.syllabusId = oldModel.syllabusId;

            for (int i = 0; i < viewModel.noOfQuestiones; i++)
            {
                var function = Gr12Wrapper
                .GetSubSyllabusQuestionGenerator(viewModel.syllabusId); // SubSyllabusID
                var temp = function.Invoke(parameter);
                allQuestions += temp.Split('$')[0] + "$";
                allAnswers += temp.Split('$')[1] + "$";
                questions.Add(temp.Split('$')[0]);
                answers.Add(temp.Split('$')[1]);
                function = null;
                MyTimer.IntervalTimer_Elapsed(0.5m);
            }

            viewModel.questions = questions;
            viewModel.answers = answers;
            viewModel.allAnswers = answers;
            viewModel.preview = false;
            viewModel.allSyllabusTiems = syllabusList;
            viewModel.HomeWorkID = homeworkID;

            return View(viewModel);
        }
    }
}