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
		public IActionResult Index([Bind("firstname,lastname,cpr,phonenumber,usertype")]UserModel user)
        {
			
			if (user.usertype == "Admin")
			{
				return RedirectToAction("Index", "Admin",user);
			}
			if(user.usertype == "Basic"){
				return RedirectToAction("Index", "Basic",user);
			}
			else
				return View();
        }
       

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
