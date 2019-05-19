using System;
using System.ComponentModel.DataAnnotations;

namespace TestingFinalExam.Models
{
	public class UserModel
	{
		
		[StringLength(30, MinimumLength = 3)]
		[Required(ErrorMessage ="firstname required")]
			public string firstname
		{
			get;
			set;
		}

		[StringLength(30, MinimumLength = 1)]
        [Required]
		public string lastname
		{
			get;
			set;
		}
        
		[Range(1000000000,9999999999)]
		public int cpr
		{
			get;
			set;
		}

		[Range(10000000, 99999999)]
		[Phone]
        [Required]
		public int phonenumber
		{
			get;
			set;
		}

		[StringLength(5, MinimumLength = 5)]
        [Required]
		public string usertype
		{
			get;
			set;
		}
	}
}
