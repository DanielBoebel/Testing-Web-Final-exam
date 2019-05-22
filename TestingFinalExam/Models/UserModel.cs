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

        
		public int phonenumber
		{
			get;
			set;
		}

		public int age
        {
            get;
            set;
        }


		public string email
		{
			get;
			set;
		}


	}
}
