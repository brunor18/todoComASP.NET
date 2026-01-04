using Microsoft.AspNetCore.Mvc;


namespace testeweb.Controllers;

public class NovoController : Controller
{
    public IActionResult Index() // rota padrao
    {
        return View();
    }
}   