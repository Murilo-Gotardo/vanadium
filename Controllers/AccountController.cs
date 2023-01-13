using Microsoft.AspNetCore.Mvc;

namespace vanadium.Controllers
{
	public class AccountController : Controller
	{

		public IActionResult Login()
		{
			return View();
		}
	}
}
