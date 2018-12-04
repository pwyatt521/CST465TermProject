using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm.Models
{
    public class MultipleChoiceQuestion : TestQuestion
    {
        public MultipleChoiceQuestion(int id, string question, List<string> choices){
            this.ID = id;
            this.Question = question;
            this.Choices = choices;
        }
        [Required (ErrorMessage ="Must enter an answer for this question")]
        public override string Answer { get; set; }
        public List<string> Choices {get; set;}
    }
}
