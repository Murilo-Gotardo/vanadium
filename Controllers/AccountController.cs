using Microsoft.AspNetCore.Mvc;
using vanadium.Models;
using FluentValidation.Results;
using vanadium.Validator;
using vanadium.Data;

namespace vanadium.Controllers
{
	public class AccountController : Controller
	{

        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Login()
		{
            UserViewModel user = new UserViewModel();

            return View(user);
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

                return View(user);
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
