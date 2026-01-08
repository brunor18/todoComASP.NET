using Microsoft.AspNetCore.Mvc;
using testeweb.Models;
using testeweb.Contexts;


namespace testeweb.Controllers;

public class TodoController : Controller
{
    
        private readonly testewebContext _context;

        public TodoController(testewebContext context)
        {
            _context = context;
        }

    public IActionResult Index() // rota padrao
    {
        ViewData["Title"] = "Lista de Tarefas";
        var todo = _context.Todos.ToList();
        return View(todo);
    }
}   