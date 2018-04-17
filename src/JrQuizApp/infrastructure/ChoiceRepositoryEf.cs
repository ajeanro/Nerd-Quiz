using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace infrastructure
{
    public class ChoiceRepositoryEf : IChoiceRepository
    {
        private readonly QuizContext _DbContext;

        public ChoiceRepositoryEf(QuizContext DbContext)
        {
            _DbContext = DbContext;
        }

        public void Add(Choice NewChoice)
        {
            _DbContext.Add(NewChoice);

            _DbContext.SaveChanges();
        }

        public List<Choice> ResultQuiz()
        {
            return _DbContext.Choices.ToList();
               
        }

        public IEnumerable<Choice> GetByQuestion(Question question)
        {
            return _DbContext.Choices.Where(c => c.QuestionId == question.Id);
        }

        public void Delete(Choice ChoiceToDelete)
        {
           
        }

        public Choice GetById(int Id)
        {
            return new Choice();
        }

        public void Update(Choice EditedChoice)
        {
            
        }
    }
}
