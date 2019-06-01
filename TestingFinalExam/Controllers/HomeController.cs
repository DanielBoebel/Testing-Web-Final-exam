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
       

		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Login([Bind("firstname,lastname,phonenumber,age,guessScore")]UserModel user)
        {
            
			string errormessageFirstname = validateFirstname(user.firstname);
            ModelState.AddModelError("firstname", errormessageFirstname);

            string errormessageLastname = validateLastname(user.lastname);
            ModelState.AddModelError("lastname", errormessageLastname);

            string errormessagePhonenumber = validatePhonenumber(user.phonenumber);
            ModelState.AddModelError("phonenumber", errormessagePhonenumber);

            string errormessageAge = validateAge(user.age);
            ModelState.AddModelError("age", errormessageAge);

            string errormessageGuessScore = validateGuessScore(user.guessScore);
            ModelState.AddModelError("guessScore", errormessageGuessScore);

            if (errormessageFirstname == "" && errormessageLastname == "" && errormessagePhonenumber == "" && errormessageAge == "" && errormessageGuessScore == "")
			{
                MathLogicController mathLogicController = new MathLogicController();
                mathLogicController.SetUser(user);
                return RedirectToAction("Index", "MathLogic");
			}

			return View();
        }


        public string validateFirstname(string firstname) {
            string errormessage = "";

            if (firstname.Length >= 20)
            {
                ViewBag.firstnameTrue = true;
                errormessage = "Your firstname needs to be less then 20 characters";
                //ModelState.AddModelError("firstname", errormessage);
                return errormessage;
            }
            else if (firstname.Any(char.IsDigit) == true)
            {
                ViewBag.firstnameTrue = true;
                errormessage = "Your name can not contain digits";
                //ModelState.AddModelError("firstname", errormessage);
                return errormessage;
            }
            else if (firstname.Any(char.IsSymbol) == true)
            {
                ViewBag.firstnameTrue = true;
                errormessage = "Your name can not contain symbols";
                //ModelState.AddModelError("firstname", errormessage);
                return errormessage;
            }

            return errormessage;
        }

        public string validateLastname(string lastname)
        {
            string errormessage = "";

            if (lastname.Length >= 20)
            {
                ViewBag.lastnameTrue = true;
                errormessage = "Your lastname needs to be less then 20 characters";
                //ModelState.AddModelError("lastname", errormessage);
                return errormessage;
            }
            else if (lastname.Any(char.IsDigit) == true)
            {
                ViewBag.lastnameTrue = true;
                errormessage = "Your lastname can not contain digits";
                //ModelState.AddModelError("lastname", errormessage);
                return errormessage;
            }
            else if (lastname.Any(char.IsSymbol) == true)
            {
                ViewBag.lastnameTrue = true;
                errormessage = "Your lastname can not contain symbols";
                //ModelState.AddModelError("lastname", errormessage);
                return errormessage;
            }

            return errormessage;
        }

        public string validatePhonenumber(string phonenumber)
        {
            string errormessage = "";

            if (phonenumber.ToString().Length != 8 && !phonenumber.ToString().Equals("0"))
            {
                ViewBag.phonenumberTrue = true;
                errormessage = "Phonenumber needs to be exactly 8 digits";
                //ModelState.AddModelError("phonenumber", errormessage);
                return errormessage;
            }
            else if (phonenumber.ToString().Any(char.IsLetter) == true || phonenumber.ToString().Any(char.IsSymbol) == true)
            {
                ViewBag.phonenumberTrue = true;
                errormessage = "Phonenumber can not contain letters or symbols";
                //ModelState.AddModelError("phonenumber", errormessage);
                return errormessage;
            }

            return errormessage;
        }

        public string validateAge(int age)
        {
            string errormessage = "";

            if (!age.ToString().Any(char.IsDigit) == true)
            {
                ViewBag.ageTrue = true;
                errormessage = "Age must be numeric value";
                //ModelState.AddModelError("age", errormessage);
                return errormessage;
            }
            else if (age < 5 || age > 12)
            {
                ViewBag.ageTrue = true;
                errormessage = "To enter, you must between the age 5-12 to enter";
                //ModelState.AddModelError("age", errormessage);
                return errormessage;
            }

            return errormessage;
        }

        public string validateGuessScore(int guessScore)
        {
            string errormessage = "";

            if (guessScore < -7 || guessScore > 14)
            {
                ViewBag.guessScore = true;
                errormessage = "Guess has to be between -7 and 14";
                //ModelState.AddModelError("guessScore", errormessage);
                return errormessage;
            }

            return errormessage;
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



    }
}
