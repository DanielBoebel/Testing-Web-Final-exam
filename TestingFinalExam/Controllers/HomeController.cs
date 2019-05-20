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
		public IActionResult Index([Bind("firstname,lastname,phonenumber,cprnumber,usertype")]UserModel user)
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
    				errormessage = "Phonenumber dosent fit the requirements";
                ModelState.AddModelError("phonenumber", errormessage);
			}
			else if (user.cprnumber.ToString().Length != 10 )
			{
                ViewBag.cprnumberTrue = true;
                errormessage = "Cprnumber dosent fit the requirements";
                ModelState.AddModelError("cprnumber", errormessage);
            }
			else if(user.usertype != "Basic" && user.usertype != "Admin")
			{
				ViewBag.usertypeTrue = true;
				errormessage = "Usertype has to be Basic or Admin";
                ModelState.AddModelError("usertype", errormessage);
			}

			else{
				errormessage = "";
			}


			if (errormessage == "")
			{
				if (user.usertype == "Admin")
				{
					return RedirectToAction("Index", "Admin", user);
				}
				if (user.usertype == "Basic")
				{
					return RedirectToAction("Index", "Basic", user);
				}
			}

			return View();
        }
       

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
