using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace infrastructure
{
    public class QuizRepositoryEf : IQuizRepository
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
            return _DbContext.Quizzes
                .Include(q => q.Questions)
                .ThenInclude(q => q.Choices)
                .FirstOrDefault(q => q.Id == id);
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
