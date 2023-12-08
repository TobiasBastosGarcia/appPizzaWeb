using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PizzaAppWeb.Models;
using PizzaAppWeb.Services;

namespace PizzaAppWeb.Pages
{
    public class CreateModel : PageModel
    {
        public SelectList MarcaOptionItems { get; set; }

        private IPizzaService _service;
        public CreateModel(IPizzaService service) 
        {
            _service = service;
        }

        public void OnGet()
        {
            MarcaOptionItems = new SelectList(_service.ObterTodasMarcas(),
            nameof(Marca.MarcaId),
            nameof(Marca.Descricao));
        }


        [BindProperty]
        public Pizza Pizza { get; set; }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            _service.Incluir(Pizza);

            return RedirectToPage("/Index");

        }
    }
}
