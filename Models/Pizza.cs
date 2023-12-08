using System.ComponentModel.DataAnnotations;

namespace PizzaAppWeb.Models;

public class Pizza
{
    public int PizzaId { get; set; }

    [StringLength(50, MinimumLength = 10, ErrorMessage = "Campo 'Nome' deve ter entre 10 e 50 caracteres")]
    [Required(ErrorMessage ="Campo 'Nome' Obrigatório.")]
    public string Nome { get; set; }
    public string NomeSlug => Nome.ToLower().Replace(" ", "-");

    [StringLength(100, MinimumLength = 50, ErrorMessage = "Campo 'Descrição' deve ter entre 50 e 100 caracteres")]
    [Required(ErrorMessage = "Campo 'Descrição' Obrigatório.")]
    [Display(Name = "Descrição")]
    public string Descricao { get; set; }


    [Required(ErrorMessage = "Campo 'Caminho URL da imagem' Obrigatório.")]
    [Display(Name = "Caminho URL da imagem")]
    public string ImagemUri { get; set; }


    [Required(ErrorMessage = "Campo 'Preco' Obrigatório.")]
    [Display(Name ="Preço")]
    [DataType(DataType.Currency)]
    public double Preco { get; set; }


    [Required(ErrorMessage = "Campo 'Entrega Expressa' Obrigatório.")]
    [Display(Name = "Entrega Expressa")]
    public bool EntregaExpressa { get; set; }
    [Display(Name = "Entrega Expressa")]
    public String EntregaExpressaFormatada => EntregaExpressa ? "Sim" : "Não";


    [Required(ErrorMessage = "Campo 'Data de Cadastro' Obrigatório.")]
    [Display(Name = "Disponível em")]
    [DisplayFormat(DataFormatString ="{0:MMMM \\de yyyy}")]
    [DataType("month")]
    public DateTime DataCadastro { get; set; }

    [Display(Name = "Marca")]
    public int? MarcaId { get; set; }
}
