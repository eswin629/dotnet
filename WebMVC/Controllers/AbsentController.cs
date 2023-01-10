using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers;

public class AbsentController : Controller
{
    public IActionResult List()
    {
        return View();
    }
}
