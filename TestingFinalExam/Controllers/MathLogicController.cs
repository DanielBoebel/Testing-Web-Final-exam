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
        static public UserModel user = new UserModel();

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


			modulusNumber(rnd1);

			int rndAddNumb1 = rnd1.Next(31, 101);
            int rndAddNumb2 = rnd1.Next(5, 30);
			mathobjpublic.addNumb1 = rndAddNumb1;
            mathobjpublic.addNumb2 = rndAddNumb2;

			string pi = "Pi";
			mathobjpublic.piCorrect = pi;

			string sum = "Sum";
			mathobjpublic.sumCorrect = sum;

			ViewBag.rndMulNumber1 = rndMulNumb1;
			ViewBag.rndMulNumber2 = rndMulNumb2;

			ViewBag.rndSubNumber1 = rndSubNumb1;
            ViewBag.rndSubNumber2 = rndSubNumb2;
           

			ViewBag.rndAddNumber1 = rndAddNumb1;
            ViewBag.rndAddNumber2 = rndAddNumb2;

			ViewBag.pi = pi;
			ViewBag.sum = sum;

            return View();
        }

		[HttpPost]
		public IActionResult Index([Bind("addAnswer","subAnswer","divAnswer","multiplyAnswer", "multipleNumbAnswer", "piAnswer","sumAnswer")] MathModel mathobj)
		{
			addNumbers(mathobj.addAnswer, mathobjpublic.mulNumb1, mathobjpublic.mulNumb2);
			subNumbers(mathobj.subAnswer, mathobjpublic.subNumb1, mathobjpublic.subNumb2);
			divNumbers(mathobj.divAnswer, mathobjpublic.divNumb1, mathobjpublic.divNumb2);
			multiplyNumbers(mathobj.multiplyAnswer, mathobjpublic.addNumb1, mathobjpublic.addNumb2);
			multipleNumbers(mathobj.multipleNumbAnswer);
			piSymbol(mathobj.piAnswer.ToLower(), mathobjpublic.piCorrect.ToLower());
			sumSymbol(mathobj.sumAnswer.ToLower(), mathobjpublic.sumCorrect.ToLower());



			ViewBag.score = score;
			return View("Results");
		}

		public void modulusNumber(Random rnd1){
            double rndDivNumb1, rndDivNumb2;
            double divResult;

            do
            {
                rndDivNumb1 = rnd1.Next(31, 101);
                rndDivNumb2 = rnd1.Next(5, 30);
                divResult = rndDivNumb1 / rndDivNumb2;

                if (divResult % 1 == 0)
                {
                    mathobjpublic.divNumb1 = (int)rndDivNumb1;
                    mathobjpublic.divNumb2 = (int)rndDivNumb2;
                    ViewBag.rndDivNumber1 = rndDivNumb1;
                    ViewBag.rndDivNumber2 = rndDivNumb2;


                    break;
                }
            } while (divResult % 1 != 0);
            

		}

		public bool addNumbers(int answer, int rndNumb1, int rndNumb2)
        {
			int correct = rndNumb1 + rndNumb2;     
			if (answer == correct)
            {
				score+= 2;
				ViewBag.mulResult = true;
                    string message = "The answer is correct!";
                    ModelState.AddModelError("addAnswer", message);
                return true;

			}else{
				ViewBag.mulResult = false;
				string message = "Your answer was " + answer + ", correct answer is " + correct;
                ModelState.AddModelError("addAnswer", message);
				score +=- 1;
                return false;
			}         
        }
        

		public bool subNumbers(int answer, int rndNumb1, int rndNumb2)
        {
            int correct = rndNumb1 - rndNumb2;
            if (answer == correct)
            {
				score+= 2;
                ViewBag.subResult = true;
                    string message = "The answer is correct!";
                    ModelState.AddModelError("subAnswer", message);
                return true;
            }else{
                ViewBag.subResult = false;
				string message = "Your answer was " + answer + ", correct answer is " + correct;
                ModelState.AddModelError("subAnswer", message);
                score +=- 1;
                return false;
            }  
        }

		public bool divNumbers(int answer, int rndNumb1, int rndNumb2)
        {
            int correct = rndNumb1 / rndNumb2;
            if (answer == correct)
            {
				score+= 2;
                ViewBag.divResult = true;
                    string message = "The answer is correct!";
                    ModelState.AddModelError("divAnswer", message);
                return true;

            }else{
                ViewBag.divResult = false;
				string message = "Your answer was " + answer + ", correct answer is " + correct;
                ModelState.AddModelError("divAnswer", message);
                score +=- 1;
                return false;
            }  
        }

		public bool multiplyNumbers(int answer, int rndNumb1, int rndNumb2)
        {
            int correct = rndNumb1 * rndNumb2;
            if (answer == correct)
            {
				score+= 2;
                ViewBag.addResult = true;
                    string message = "The answer is correct!";
                    ModelState.AddModelError("multiplyAnswer", message);
                return true;

            }else{
                ViewBag.addResult = false;
				string message = "Your answer was " + answer + ", correct answer is " + correct;
                ModelState.AddModelError("multiplyAnswer", message);
                score +=- 1;
                return false;
            }  
        }

		public bool multipleNumbers(string multipleNumbers)
		{
			var totalNumber = 0;
			 string[] numbers = multipleNumbers.Split(",");
			foreach (var item in numbers)
			{
				int number;
				Int32.TryParse(item, out number);

				if (number % 2 == 0)
				{
					totalNumber += 1;
				}
			}

			if(totalNumber == 4){
				score += 2;
				ViewBag.numbResult = true;
				string message = "The answer is correct!";
				ModelState.AddModelError("multipleNumbAnswer", message);
				return true;
			}
			else
			{
				ViewBag.numbResult = false;
				string message = "Your answer was not correct";
				ModelState.AddModelError("multipleNumbAnswer", message);
				score += -1;
				return false;
			}

		}

		public bool piSymbol(string answer, string correct)
		{
			if(answer == correct){
				score+= 2;
					ViewBag.piResult = true;
					string message = "The answer is correct!";
					ModelState.AddModelError(correct.ToLower() + "Answer", message);
                return true;
            }else{
               
                score +=- 1;
				ViewBag.piResult = false;
				string message = "Your answer was "+answer+", correct answer is "+correct;
                ModelState.AddModelError(correct.ToLower() + "Answer", message);
                return false;
            }  
		}

		public bool sumSymbol(string answer, string correct)
        {
            if (answer == correct)
            {
				score += 2;
                ViewBag.sumResult = true;
                string message = "The answer is correct!";
                ModelState.AddModelError(correct.ToLower() + "Answer", message);
                return true;
            }
            else
            {
                score += -1;

                    ViewBag.sumResult = false;
				    string message = "Your answer was " + answer + ", correct answer is " + correct;
                    ModelState.AddModelError(correct.ToLower() + "Answer", message);
                return false;
            }
        }

        public IActionResult Printable()
        {
            ViewBag.score = score;
            ViewBag.user = user;
            return View("Printable");
        }

        public void SetUser(UserModel userModel)
        {
            user = userModel;
        }

    }
}
