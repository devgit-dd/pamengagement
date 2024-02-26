using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class AllData
    {
        public List<QuestionDetails> Data {get;set;}
        public AllData ()
        {
            Data = new List<QuestionDetails>();
        }
    }
    public class QuestionDetails
    {
        public string Id {get;set;}
        public string Name {get;set;}
        public string Path {get;set;}
        public List<SingleQuestion> Questions {get;set;}
        public List<string> HintText {get;set;}
        public bool Blur {get;set;}
        public QuestionDetails()
        {
            Questions = new List<SingleQuestion>();
        }
    }
    public class SingleQuestion
    {
        public string Id {get;set;}
        public string Text {get;set;}
        public string Answer {get;set;}
    }
}