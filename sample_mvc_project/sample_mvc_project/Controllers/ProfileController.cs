using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Xml.Linq;

namespace MvcMovie.Controllers
{
    public class ProfileController : Controller
    {
        // 
        // GET: /Profile/
        // Index method will run as the default of this controller.
        // IActionRsult represent various HTTP status codes. Any non-abstract class deriving from ActionResult qualifies as a valid return type.

        public IActionResult Index()
        {
            // Lets you go the view of thi method.
            return View();
        }

        //
        // GET: /Profile/Details/
        // This method pass values from controller to the view.

        public IActionResult Details(string name, int age, string status)

        // In here, we declare data as parameter of the method to be pass on through this controller method to the view.
        {
            ViewData["Greet"] = "Name: " + name;
            ViewData["Age"] = "Age: " + age;
            ViewData["Status"] = "Status: " + status;

            return View();
        }
    }
}