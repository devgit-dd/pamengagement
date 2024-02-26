using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DevEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
//using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public partial class DBOperations
    {
        public pamengagementContext context;
        public void GetContext()
        {
            //context = new PfizerProgrametracker_Scoping_ProdEntities();
            //context = new PfizerProgrametracker_DevContext();
            context = new pamengagementContext();
            //context = new PfizerProgrametracker_StgContext();

        }
        public List<tbldata_questiondetail> GetAllQuestionDetails()
        {
            GetContext();
            List<tbldata_questiondetail> questiondetails = new();
            try
            {
                questiondetails = context.tbldata_questiondetails.ToList();
                return questiondetails;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:"+ex);
                return questiondetails;
            }
            
        }
        public List<tbldata_answer> GetAllAnswerDetails()
        {
            GetContext();
            List<tbldata_answer> answers = new();
            try
            {
                answers = context.tbldata_answers.ToList();
                return answers;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:"+ex);
                return answers;
            }
            
        }
    }
}

