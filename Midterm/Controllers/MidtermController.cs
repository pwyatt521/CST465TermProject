using System.Web;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Midterm.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Midterm.Controllers
{
    public class Midterm : Controller
    {
        private const string midtermJson = "JSON/Midterm.json";
        private List<TestQuestion> questions;

        public Midterm()
        {
            questions = new List<TestQuestion>();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult TakeTest(IEnumerable<TestQuestion> qs){
            
            if (!ModelState.IsValid){
                return View(qs);         
            }
            return View("DisplayResults", qs);
        }
        [HttpGet]
        public ActionResult TakeTest(){
            ReadJson();
            return View(questions);
        }
        public void ReadJson()
        {
            List<JSonDeserialize> jsonData = new List<JSonDeserialize>();
            using (StreamReader r = new StreamReader(midtermJson))
            {
                string json = r.ReadToEnd();
                jsonData = JsonConvert.DeserializeObject<List<JSonDeserialize>>(json);
            }
            foreach (JSonDeserialize data in jsonData){
                switch(data.type)
                {
                    case "TrueFalseQuestion":
                        questions.Add(new TrueFalseQuestion(data.id, data.question));
                        break;
                    case "ShortAnswerQuestion":
                        questions.Add(new ShortAnswerQuestion(data.id, data.question));
                        break;
                    case "LongAnswerQuestion":
                        questions.Add(new LongAnswerQuestion(data.id, data.question));
                        break;
                    case "MultipleChoiceQuestion":
                        questions.Add(new MultipleChoiceQuestion(data.id, data.question, data.choices));
                        break;
                    default:
                        break;
                }
            
            }
        }

    }

    public class JSonDeserialize
    {
        public int id{get; set;}
        public string type {get; set;}
        public string question{get; set;}
        public List<string> choices{get;set;}
    }
}