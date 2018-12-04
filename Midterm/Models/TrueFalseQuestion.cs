using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm.Models
{
    public class TrueFalseQuestion : TestQuestion
    {
        public TrueFalseQuestion(int id, string question){
            this.ID = id;
            this.Question = question;
        }
        [Required (ErrorMessage ="Must enter an answer for this question")]
        [RegularExpression("true|false", ErrorMessage="Answer must be true or false")]
        public override string Answer { get; set; }

        public static readonly List<string> TOrF = new List<string>{
            "false", "true"
        };
    }
}
