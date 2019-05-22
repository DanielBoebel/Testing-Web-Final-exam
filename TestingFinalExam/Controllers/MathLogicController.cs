using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestingFinalExam.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestingFinalExam.Controllers
{
    public class MathLogicController : Controller
    {
		static public int score;
		static public MathModel mathobjpublic = new MathModel();


		public IActionResult Index()
        {
            Random rnd1 = new Random();
            int rndMulNumb1 = rnd1.Next(1, 500);
            int rndMulNumb2 = rnd1.Next(1, 500);
			mathobjpublic.mulNumb1 = rndMulNumb1;
			mathobjpublic.mulNumb2 = rndMulNumb2;

			int rndSubNumb1 = rnd1.Next(300, 500);
            int rndSubNumb2 = rnd1.Next(100, 299);
			mathobjpublic.subNumb1 = rndSubNumb1;
			mathobjpublic.subNumb2 = rndSubNumb2;

			double rndDivNumb1 = rnd1.Next(31, 101);
			double rndDivNumb2 = rnd1.Next(5, 30);
			double divResult = rndDivNumb1 / rndDivNumb2;
			while (divResult % 1 != 0 )
			{
				rndDivNumb1 = rnd1.Next(31, 101);
                rndDivNumb2 = rnd1.Next(5, 30);
				divResult = rndDivNumb1 / rndDivNumb2;

				if (divResult% 1 == 0)
				{
					mathobjpublic.divNumb1 = (int)rndDivNumb1;
					mathobjpublic.divNumb2 = (int)rndDivNumb2;
					break;
				}
			}

			int rndAddNumb1 = rnd1.Next(31, 101);
            int rndAddNumb2 = rnd1.Next(5, 30);
			mathobjpublic.addNumb1 = rndAddNumb1;
            mathobjpublic.addNumb2 = rndAddNumb2;

			ViewBag.rndMulNumber1 = rndMulNumb1;
			ViewBag.rndMulNumber2 = rndMulNumb2;

			ViewBag.rndSubNumber1 = rndSubNumb1;
            ViewBag.rndSubNumber2 = rndSubNumb2;

			ViewBag.rndDivNumber1 = rndDivNumb1;
            ViewBag.rndDivNumber2 = rndDivNumb2;

			ViewBag.rndAddNumber1 = rndAddNumb1;
            ViewBag.rndAddNumber2 = rndAddNumb2;

            return View();
        }

		[HttpPost]
		public IActionResult Index([Bind("mulAnswer","subAnswer","divAnswer","addAnswer")] MathModel mathobj)
		{
			mulNumbers(mathobj.mulAnswer, mathobjpublic.mulNumb1, mathobjpublic.mulNumb2);
			subNumbers(mathobj.subAnswer, mathobjpublic.subNumb1, mathobjpublic.subNumb2);
			divNumbers(mathobj.divAnswer, mathobjpublic.divNumb1, mathobjpublic.divNumb2);
			addNumbers(mathobj.addAnswer, mathobjpublic.addNumb1, mathobjpublic.addNumb2);


			ViewBag.score = score;
		    return View();
		}

		public void mulNumbers(int answer, int rndNumb1, int rndNumb2)
        {
			int correct = rndNumb1 + rndNumb2;     
			if (answer == correct)
            {
				score+= 2;
			}else{
				score +=- 1;
			}         
        }
        

		public void subNumbers(int answer, int rndNumb1, int rndNumb2)
        {
            int correct = rndNumb1 - rndNumb2;
            if (answer == correct)
            {
                score += 2;
            }
            else
            {
                score +=- 1;
            }
        }

		public void divNumbers(int answer, int rndNumb1, int rndNumb2)
        {
            int correct = rndNumb1 / rndNumb2;
            if (answer == correct)
            {
                score += 2;
            }
            else
            {
                score +=- 1;
            }
        }

		public void addNumbers(int answer, int rndNumb1, int rndNumb2)
        {
            int correct = rndNumb1 * rndNumb2;
            if (answer == correct)
            {
                score += 2;
            }
            else
            {
                score +=- 1;
            }
        }



    }
}
