using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaAppWeb.Services;
using PizzaAppWeb.Models;

namespace PizzaAppWeb.Pages
{
    public class DetailsModel : PageModel
    {
        private IPizzaService _service;
        public DetailsModel(IPizzaService service) 
        {
            _service = service;
        }

        public Pizza Pizza { get; private set; }
        public IActionResult OnGet(int id)
        {
            Pizza = _service.Obter(id);

            if (Pizza == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
