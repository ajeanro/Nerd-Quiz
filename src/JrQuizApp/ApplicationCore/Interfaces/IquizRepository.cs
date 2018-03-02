using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface IquizRepository
    {
        List<Quiz> QuizList();
        Quiz GetById(int id);
        void Add(Quiz NewQuiz);
        void Update(Quiz EditedQuiz);
        void Delete(Quiz QuizToDelete);
    }
}
