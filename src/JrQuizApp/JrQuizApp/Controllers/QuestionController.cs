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
    [Produces("application/json")]
    [Route("api/Question")]
    public class QuestionController : Controller
    {
        private readonly IQuizRepository _quizRepo;
        private readonly ILogger<QuestionController> _log;
        private readonly IQuestionRepository _questionRepo;
        private readonly IChoiceRepository _choiceRepo;

        public QuestionController(IQuizRepository quizRepo, ILogger<QuestionController> log,
            IQuestionRepository questionRepo, IChoiceRepository choiceRepo)
        {
            _quizRepo = quizRepo;
            _log = log;
            _questionRepo = questionRepo;
            _choiceRepo = choiceRepo;
        }

        // GET: api/Question
        [HttpGet]
        public IEnumerable<Quiz> Get()
        {
            return _quizRepo.QuizList();
        }

        // GET: api/Question/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult GetById(int id)
        {
            var quiztest = _quizRepo.GetById(id);
            if (quiztest == null)
            {
                return NotFound();
            }

            return new ObjectResult (quiztest);
        }
        
        // POST: api/Question
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Question/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // GET: api/Question/quiz/{quiz}
        [HttpGet("GetByQuiz/{quiz}", Name = "GetByQuiz")]
        public IActionResult GetByQuiz(Quiz quiz)
        {
            var selectQuiz = _questionRepo.GetByQuiz(quiz);
            if (selectQuiz == null)
            {
                return NotFound();
            }

            return new ObjectResult(selectQuiz);
        }

    }
}
