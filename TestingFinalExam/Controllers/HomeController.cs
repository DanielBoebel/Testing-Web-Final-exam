using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestingFinalExam.Models;

namespace TestingFinalExam.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index([Bind("firstname,lastname,phonenumber,age,email")]UserModel user)
        {
			string errormessage = "";
            
			if(user.firstname.Length >= 30)
			{
				ViewBag.firstnameTrue = true;
				errormessage = "Your firstname needs to be less then 30 charectors";            
				ModelState.AddModelError("firstname", errormessage);
			}
			else if (user.firstname.Any(char.IsDigit)==true)
            {
                ViewBag.firstnameTrue = true;
                errormessage = "Your name can not contain digits";
                ModelState.AddModelError("firstname", errormessage);
            }
			else if (user.firstname.Any(char.IsSymbol) == true)
            {
                ViewBag.firstnameTrue = true;
                errormessage = "Your name can not contain symbols";
                ModelState.AddModelError("firstname", errormessage);
            }

			else if (user.lastname.Length >= 30)
            {
                ViewBag.lastnameTrue = true;
                errormessage = "Your lastname needs to be less then 30 charectors";
                ModelState.AddModelError("lastname", errormessage);
            }
			else if (user.lastname.Any(char.IsDigit) == true)
            {
                ViewBag.lastnameTrue = true;
                errormessage = "Your lastname can not contain digits";
                ModelState.AddModelError("lastname", errormessage);
            }
			else if (user.lastname.Any(char.IsSymbol) == true)
            {
                ViewBag.lastnameTrue = true;
                errormessage = "Your name can not contain symbols";
                ModelState.AddModelError("lastname", errormessage);
            }
			else if(user.phonenumber.ToString().Length !=8){
				ViewBag.phonenumberTrue = true;
    				errormessage = "Phonenumber needs to be exactly 8 digits";
                ModelState.AddModelError("phonenumber", errormessage);
			}
			else if (user.phonenumber.ToString().Any(char.IsLetter) == true || user.phonenumber.ToString().Any(char.IsSymbol) == true)
            {
                ViewBag.phonenumberTrue = true;
                errormessage = "Phonenumber can not contain letters or symbols";
                ModelState.AddModelError("phonenumber", errormessage);
            }
			else if (!user.age.ToString().Any(char.IsDigit)==true)
            {
                ViewBag.ageTrue = true;
                errormessage = "Age must be numeric value";
                ModelState.AddModelError("age", errormessage);
            }
			else if (user.age <3 || user.age >13)
            {
                ViewBag.ageTrue = true;
                errormessage = "To enter, you must between the age 3-13 to enter";
                ModelState.AddModelError("age", errormessage);
            }
			else if(user.email.ToString().Length >=50 || user.email.ToString().Length <=4)
			{
				ViewBag.emailTrue = true;
				errormessage = "Email-adress is to long or to short";
                ModelState.AddModelError("email", errormessage);
			}
			else if (!user.email.Contains("@"))
            {
                ViewBag.emailTrue = true;
                errormessage = "Email-adress must contain @";
                ModelState.AddModelError("email", errormessage);
            }

			else{
				errormessage = "";
			}


			if (errormessage == "")
			{
					return RedirectToAction("Index", "MathLogic");


			}

			return View();
        }
       

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
