using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm.Models
{
    public class LongAnswerQuestion : TestQuestion
    {
        public LongAnswerQuestion(int id, string question){
            this.ID = id;
            this.Question = question;
        }
        [Required (ErrorMessage ="Must enter an answer for this question")]
        public override string Answer { get; set; }
    }
}
