using PizzaAppWeb.Data;
using PizzaAppWeb.Models;

namespace PizzaAppWeb.Services.Data;

public class PizzaService : IPizzaService
{
    private PizzaDbContext _context;
    public PizzaService(PizzaDbContext context)
    {
        _context = context;
    }

    public void Alterar(Pizza pizza)
    {
        var pizzaEncontrada = Obter(pizza.PizzaId);
        pizzaEncontrada.Nome = pizza.Nome;
        pizzaEncontrada.Descricao = pizza.Descricao;
        pizzaEncontrada.Preco = pizza.Preco;
        pizzaEncontrada.ImagemUri = pizza.ImagemUri;
        pizzaEncontrada.EntregaExpressa = pizza.EntregaExpressa;
        pizzaEncontrada.DataCadastro = pizza.DataCadastro;
        pizzaEncontrada.MarcaId = pizza.MarcaId;
        _context.SaveChanges();
    }

    public void Excluir(int id)
    {
        var pizzaEncontrada = Obter(id);
        _context.Pizza.Remove(pizzaEncontrada);
        _context.SaveChanges();
    }

    public void Incluir(Pizza pizza)
    {
        _context.Pizza.Add(pizza);
        _context.SaveChanges();
    }

    public Pizza Obter(int id)
    {
        return _context.Pizza.SingleOrDefault(item => item.PizzaId == id);
    }

    public IList<Pizza> ObterTodos()
    {
        return _context.Pizza.ToList();
    }

    public IList<Marca> ObterTodasMarcas()
        =>_context.Marca.ToList();
}
