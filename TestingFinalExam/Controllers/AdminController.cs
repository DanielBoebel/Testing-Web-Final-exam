using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestingFinalExam.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestingFinalExam.Controllers
{
    public class AdminController : Controller
    {
		UserModel globalUser = new UserModel();
        
		public IActionResult Index(UserModel user)
        {
			globalUser = user;
			var cpr = user.cprnumber;
			ViewBag.user = user.firstname;
            return View();
        }
    }
}
