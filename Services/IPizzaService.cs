using PizzaAppWeb.Models;

namespace PizzaAppWeb.Services;

public interface IPizzaService
{
    IList<Pizza> ObterTodos();
    Pizza Obter(int id);
    void Incluir(Pizza pizza);
    void Alterar(Pizza pizza);
    void Excluir(int id);
    IList<Marca> ObterTodasMarcas();

}
