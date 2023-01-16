using Microsoft.AspNetCore.Mvc;
using vanadium.Models;
using FluentValidation.Results;
using vanadium.Validator;

namespace vanadium.Controllers
{
	public class AccountController : Controller
	{

		public IActionResult Login()
		{
            UserViewModel user = new UserViewModel();

            return View("Login", user);
        }

        [HttpPost]
        public IActionResult Login(UserViewModel user)
        {
            UserValidator validator = new UserValidator();

            ValidationResult results = validator.Validate(user);

            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    user.Email = ("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
                }

                return View("Login", user);
            }
            else
            {
                return View("Register");
            }

        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
