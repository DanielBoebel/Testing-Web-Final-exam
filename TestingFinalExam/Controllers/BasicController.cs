using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestingFinalExam.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestingFinalExam.Controllers
{
    public class BasicController : Controller
    {

		UserModel globalUser = new UserModel();
		public IActionResult Index(UserModel user)
        {
			globalUser = user;
			var cpr = user.cprnumber;
			calculateAge(user.cprnumber);

            return View();
        }

		public int calculateAge(long cpr){
			DateTime currenttime = DateTime.Now;
			string datetimeString = currenttime.ToString();
			char index0 = datetimeString[0];
			char index1 = datetimeString[1];
			char index3 = datetimeString[3];
			char index4 = datetimeString[4];
			char index6 = datetimeString[8];
			char index7 = datetimeString[9];

			string stringformattedDatetime = index0 +""+ index1 +""+ index3 +""+ index4 +""+ index6 +""+ index7;
			int formattedDatetime = Convert.ToInt32(stringformattedDatetime);

			string stringCPR = cpr.ToString();         
			string substringCPR = stringCPR.Substring(0, 6);
			int formattedCPR = Convert.ToInt32(substringCPR);

			ViewBag.datetime = formattedDatetime;
			ViewBag.cpr = formattedCPR;




			int finalAge = 0;



			return(finalAge);
		}
    }
}
