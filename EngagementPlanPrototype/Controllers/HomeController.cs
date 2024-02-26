using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BAL;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace DAL
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("[controller]/GetAllQuestionsData")]
        public ActionResult GetAllQuestionsData()
        {
            try
            {
                BusinessOperations BAL = new();
                AllData allQuestionsData = new();
                allQuestionsData = BAL.GetAllQuestionsData();
                if (allQuestionsData.Data.Count > 0)
                {
                    return Ok(allQuestionsData);
                }
                
                else
                {
                    return Ok();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:"+ex);
                return Ok(500);
            }
        }
        //write a function to display only the answers
        //function to submt a reponse
        //function to show the leaderboard
    }
}