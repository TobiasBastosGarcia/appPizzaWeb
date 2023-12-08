using Microsoft.EntityFrameworkCore.Migrations;
using PizzaAppWeb.Models;
using System.Security.Cryptography.Xml;

#nullable disable

namespace PizzaAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarDadosIniciaisMarca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new PizzaDbContext();
            context.Marca.AddRange(ObterCargaInicialMarca());
            context.SaveChanges();
        }

        private IList<Marca> ObterCargaInicialMarca()
        {
            return new List<Marca>()
            {
                new Marca() {Descricao = "Sadia" },
                new Marca() {Descricao = "Perdigão"},
                new Marca() {Descricao = "Seara"},
            };

        }
       
    }
}
