using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm.Models
{
    public class ShortAnswerQuestion : TestQuestion
    {
        public ShortAnswerQuestion(int id, string question){
            this.ID = id;
            this.Question = question;
        }
        [Required (ErrorMessage ="Must enter an answer for this question")]
        [MaxLength(100, ErrorMessage = "Answer cannot be longer than 40 characters")]
        public override string Answer { get; set; }
    }
}
