using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;

namespace XuongMoc.Controllers
{
    [Area("Admins")]
    public class LoginController : Controller
    {
        [HttpGet] // get, hiển thị form để nhập dữ liệu
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost] // Post -> khi submit form
        public IActionResult Index(Login model)
        {
            if (!ModelState.IsValid) 
            {
                return View(model);
            }
            return View();
        }
    }
}
