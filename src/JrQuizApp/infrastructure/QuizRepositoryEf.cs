using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace infrastructure
{
    public class QuizRepositoryEf : IquizRepository
    {
        private readonly QuizContext _DbContext;

        public QuizRepositoryEf(QuizContext DbContext)
        {
            _DbContext = DbContext;
        }

        public void Add(Quiz NewQuiz)
        {
            _DbContext.Add(NewQuiz);
            _DbContext.SaveChanges();
        }

        public void Delete(Quiz QuizToDelete)
        {
            
        }

        public Quiz GetById(int id)
        {
            return new Quiz();
        }

        public List<Quiz> QuizList()
        {
            return _DbContext.Quizzes.ToList();
        }

        public void Update(Quiz EditedQuiz)
        {
           
        }
    }
}
