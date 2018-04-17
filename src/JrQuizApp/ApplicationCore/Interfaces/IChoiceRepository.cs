using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface IChoiceRepository
    {
        List<Choice> ResultQuiz();
        Choice GetById(int Id);
        void Add(Choice NewChoice);
        void Update(Choice EditedChoice);
        void Delete(Choice ChoiceToDelete);
        IEnumerable<Choice> GetByQuestion(Question question);
    }
}
