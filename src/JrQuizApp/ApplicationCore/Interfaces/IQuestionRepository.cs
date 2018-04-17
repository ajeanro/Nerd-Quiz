using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface IQuestionRepository
    {
        List<Question> QuestionList();
        Question GetById(int Id);
        void Add(Question NewQuestion);
        void Update(Question EditedQuestion);
        void Delete(Question QuestionToDelete);
        void Add(Choice NewChoice);
        IEnumerable<Question> GetByQuiz(Quiz quiz);
        
    }
}
