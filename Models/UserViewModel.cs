﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vanadium.Models
{

	[Table("Livros")]
	public class UserViewModel
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Email { get; set; }

		public string Password { get; set; }

	}
}
