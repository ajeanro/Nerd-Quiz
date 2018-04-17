using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Web.Controllers
{
    public class QuizManagerController : Controller
    {
        private readonly IQuizRepository _quizRepo;
        private readonly ILogger<QuizManagerController> _log;
        private readonly IQuestionRepository _questionRepo;
        private readonly IChoiceRepository _choiceRepo;

        public QuizManagerController(IQuizRepository quizRepo, ILogger<QuizManagerController> log,
            IQuestionRepository questionRepo, IChoiceRepository choiceRepo)


        {
            _quizRepo = quizRepo;
            _log = log;
            _questionRepo = questionRepo;
            _choiceRepo = choiceRepo;
        }

        // GET: QuizManager
        public ActionResult Index()
        {
            return View(_quizRepo.QuizList());
        }

        //GET: QuizManager/Question
        public ActionResult Challenge(Quiz quiz)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    List<Question> Questions = new List<Question>();
                    List<Choice> Choices = new List<Choice>();
                    var questions = _questionRepo.GetByQuiz(quiz);
                    //Choices = _choiceRepo.GetByQuestion(_questionRepo.GetById(id));
                    foreach (var question in Questions)
                    {
                        var choices = _choiceRepo.GetByQuestion(question);
                        question.Choices = Choices.ToList();
                    }
                    return View(quiz);
                }
            }
            catch(Exception ex)
            {
                _log.LogError(ex, "Error loading Quiz Test");
            }
            return View();
        }

        

        // GET: QuizManager/Details/5
        public ActionResult Details(int id)
        {
            return View(_quizRepo.GetById(id));
        }

        // GET: QuizManager/Details/5
        public ActionResult Details2(int id)
        {
            return View(_quizRepo.GetById(id));
        }

        [HttpPost]
        public ActionResult GradeQuiz(Quiz quiz, IFormCollection collection)
        {

            return View();
        }

        // POST: QuizManager/Details


        // GET: QuizManager/Create
        public ActionResult Create()
        {
            return View(new Quiz());
        }

        // POST: QuizManager/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Quiz newquiz)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _quizRepo.Add(newquiz);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch(Exception ex)
            {
                _log.LogError(ex, "Error creating quiz."); ;
            }
            return View();
        }

        // GET: QuizManager/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_quizRepo.GetById(id));
        }

        // POST: QuizManager/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Quiz editedquiz)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _quizRepo.Update(editedquiz);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                _log.LogError(ex, "Error updating quiz."); 
            }
            return View(editedquiz);
        }

        // GET: QuizManager/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_quizRepo.GetById(id));
        }

        // POST: QuizManager/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Quiz quizToDelete)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _quizRepo.Delete(quizToDelete);
                    return RedirectToAction(nameof(Index));
                }
            }
            catch(Exception ex)
            {
                _log.LogError(ex, "Error deleting quiz.");
            }
            return View();
        }
    }
}