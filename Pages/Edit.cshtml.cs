using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PizzaAppWeb.Models;
using PizzaAppWeb.Services;

namespace PizzaAppWeb.Pages
{
    public class EditModel : PageModel
    {
        public SelectList MarcaOptionItems { get; set; }

        private IPizzaService _service;
        public EditModel(IPizzaService service)
        {
            _service = service;
        }

        [BindProperty]
        public Pizza Pizza { get; set; }

        public IActionResult OnGet(int id)
        {
            Pizza = _service.Obter(id);


            MarcaOptionItems = new SelectList(_service.ObterTodasMarcas(),
            nameof(Marca.MarcaId),
            nameof(Marca.Descricao));


            if (Pizza == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _service.Alterar(Pizza);

            return RedirectToPage("/Index");

        }

        public IActionResult OnPostExclusao()
        {
            _service.Excluir(Pizza.PizzaId);

            return RedirectToPage("/Index");
        }

    }
}
