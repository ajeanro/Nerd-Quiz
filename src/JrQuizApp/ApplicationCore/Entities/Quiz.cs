using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public List<Question> Questions { get; set; }
                                           

    }
}
