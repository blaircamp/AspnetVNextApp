using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.ModelBinding;


namespace WebApplication
{

	[Route("")]
	public class HomeController : Controller
	{
		public IActionResult Index(){

			return View();

		}

	}

}