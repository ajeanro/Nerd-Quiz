using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace infrastructure
{
    public class QuestionRepositoryEf : IQuestionRepository
    {
        private readonly QuizContext _DbContext;

        public QuestionRepositoryEf(QuizContext DbContext)
        {
            _DbContext = DbContext;
        }

        public void Add(Question NewQuestion)
        {
            _DbContext.Add(NewQuestion);

            _DbContext.SaveChanges();
        }

        public void Add(Choice NewChoice)
        {
            _DbContext.Add(NewChoice);

            _DbContext.SaveChanges();
        }

        public void Delete(Question QuestionToDelete)
        {
            
        }

        public Question GetById(int Id)
        {
            return new Question();
        }

        public List<Question> QuestionList()
        {
            return _DbContext.Questions.ToList();
        }

        public IEnumerable<Question> GetByQuiz(Quiz quiz)
        {
            return _DbContext.Questions.Where(q => q.QuizId == quiz.Id);
            
        }

        public void Update(Question EditedQuestion)
        {
            
        }
    }
}
