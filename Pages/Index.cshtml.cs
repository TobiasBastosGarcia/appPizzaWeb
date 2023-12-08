
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaAppWeb.Models;
using PizzaAppWeb.Services;

namespace PizzaAppWeb.Pages;

public class IndexModel : PageModel
{
    private IPizzaService _service;
    public IndexModel (IPizzaService service)
    {
        _service = service;
    }

    public IList<Pizza> ListaPizza { get; private set; }
    public void OnGet()
    {
        ViewData["Title"] = "Home page";

       ListaPizza = _service.ObterTodos();
     }
}
