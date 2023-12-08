namespace PizzaAppWeb.Models;

public class Marca
{
    public int MarcaId {  get; set; }
    public string Descricao { get; set; }

    public ICollection<Pizza> Pizzas { get; set; }

}
