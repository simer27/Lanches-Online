using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lanches_Online.Migrations
{
    /// <inheritdoc />
    public partial class DataCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Categorias(Nome, Descricao) values ('Bebidas','Bebidas como Suco, Refrigerantes, Agua Mineral')");
            mb.Sql("Insert into Categorias(Nome, Descricao) values ('Lanches','Lanches Naturais, Hamburgues')");
            mb.Sql("Insert into Categorias(Nome, Descricao) values ('Batatas','Batatas grande, média e pequena')");
            mb.Sql("Insert into Categorias(Nome, Descricao) values ('Sobremesas','Pudim de Leite, Bolos Recheados e Mousses')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Categorias");
        }
    }
}
