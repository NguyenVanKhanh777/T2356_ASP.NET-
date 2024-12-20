using Microsoft.AspNetCore.Mvc;

namespace DevXuongMoc.Areas.Admin.Controllers
{
    public class DashboardController : BaseController
    {
        [Area("Admins")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
