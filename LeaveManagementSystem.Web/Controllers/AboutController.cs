using Microsoft.AspNetCore.Mvc;
using LeaveManagementSystem.Web.Models;

namespace LeaveManagementSystem.Web.Controllers;

public class AboutController : Controller
{
    public IActionResult Index()
    {
        var model = new AboutViewModel();
        return View(model);
    }
}
