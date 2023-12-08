using PizzaAppWeb.Models;

namespace PizzaAppWeb.Services.Memory;

public class PizzaService : IPizzaService
{
    public PizzaService()
        => CarregarListaInicial();

    private IList<Pizza> _pizzas;

    private void CarregarListaInicial()
    {
        _pizzas = new List<Pizza>()
        {
             new Pizza
            {
                PizzaId = 1,
                Nome = "Alho",
                Descricao = "Pizza de alho: sabor intenso, queijo derretido, massa crocante. Uma explosão de delícias em cada pedaço.",
                ImagemUri = "/images/pizzaAlho.jpg",
                Preco = 60.00,
                EntregaExpressa = true,
                DataCadastro = DateTime.Now
            },

            new Pizza
            {
                PizzaId = 2,
                Nome = "Calabresa",
                Descricao = "Calabresa irresistível, massa crocante, queijo derretido. Perfeição em cada mordida.",
                ImagemUri = "/images/pizzaCalabresa.jpg",
                Preco = 65.00,
                EntregaExpressa = true,
                DataCadastro = DateTime.Now
            },

            new Pizza
            {
                PizzaId = 3,
                Nome = "Portuguesa",
                Descricao = "Pizza Portuguesa: Presunto, ovos, cebola, azeitonas. Uma viagem de sabores em cada fatia.",
                ImagemUri = "/images/pizzaPortuguesa.jpg",
                Preco = 70.00,
                EntregaExpressa = true,
                DataCadastro = DateTime.Now
            }

        };
    }

    public IList<Pizza> ObterTodos()
        => _pizzas;

    public Pizza Obter(int id)
    {
        return ObterTodos().SingleOrDefault(item => item.PizzaId == id);
    }

    public void Incluir(Pizza pizza)
    {
        var proximoId = _pizzas.Max(item => item.PizzaId) + 1;
        pizza.PizzaId = proximoId;
        _pizzas.Add(pizza);
    }

    public void Alterar(Pizza pizza)
    {
        var pizzaEncontrada = _pizzas.SingleOrDefault(item => item.PizzaId == pizza.PizzaId);
        pizzaEncontrada.Nome = pizza.Nome;
        pizzaEncontrada.Descricao = pizza.Descricao;
        pizzaEncontrada.Preco = pizza.Preco;
        pizzaEncontrada.EntregaExpressa = pizza.EntregaExpressa;
        pizzaEncontrada.DataCadastro = pizza.DataCadastro;
        pizzaEncontrada.ImagemUri = pizza.ImagemUri;

    }

    public void Excluir(int id)
    {
        var pizzaEncontrada = Obter(id);
        _pizzas.Remove(pizzaEncontrada);

    }

    public IList<Marca> ObterTodasMarcas()
    {
        throw new NotImplementedException();
    }
}
