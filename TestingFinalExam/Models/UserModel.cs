using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TestingFinalExam.Models
{
	public class UserModel
	{
		
			public string firstname
		{
			get;
			set;
		}


		public string lastname
		{
			get;
			set;
		}

        
		public string phonenumber
		{
			get;
			set;
		}

		public int age
        {
            get;
            set;
        }


		public int guessScore
		{
			get;
			set;
		}


	}
}
