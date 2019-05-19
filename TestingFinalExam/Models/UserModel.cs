using System;
using System.ComponentModel.DataAnnotations;

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

		public long cprnumber
        {
            get;
            set;
        }


		public string usertype
		{
			get;
			set;
		}
	}
}
