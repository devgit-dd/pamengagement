using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using DAL;
using DAL.DevEntities;

namespace BAL
{
    public partial class BusinessOperations
    {
        public AllData GetAllQuestionsData()
        {
            DBOperations DAL = new();
            bool status = false;
            //DAL function to get all key values for single question
            //Dal function to get all questions data 
            AllData AllQuestionsData = new ();
            
            List<tbldata_questiondetail> allQuestionDetails = DAL.GetAllQuestionDetails();
            List<tbldata_answer> allAnswerDetails = DAL.GetAllAnswerDetails();
            QuestionDetails questionDetails = new();
            foreach (var question in allQuestionDetails)
            {
                questionDetails.Id = question.id.ToString();
                questionDetails.Name = question.name;
                questionDetails.Path = question.imagepath;
                questionDetails.Blur = true;
                //questionDetails.HintText = 
                List<tbldata_answer> answers = allAnswerDetails.Where(x=>x.questionid == question.id).ToList();
                SingleQuestion singleQuestion = new();
                foreach (var item in answers)
                {
                    singleQuestion.Id = item.id.ToString();
                    singleQuestion.Answer = item.answer;
                    singleQuestion.Text = item.text_for_question;
                    questionDetails.Questions.Add(singleQuestion);
                }
                AllQuestionsData.Data.Add(questionDetails);
            }
            return AllQuestionsData;
        }
    }
}

