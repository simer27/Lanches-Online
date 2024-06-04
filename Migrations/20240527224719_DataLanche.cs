using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lanches_Online.Migrations
{
    /// <inheritdoc />
    public partial class DataLanche : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImageUrl, ImageThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) " +
                "values ('X-Salada','X-Salada Clássico','X-Salada: clássico hambúrguer composto por pão macio, carne bovina grelhada, queijo derretido, alface fresca, tomate suculento, maionese e condimentos. Sabor equilibrado e refrescante.',19.99,'https://www.google.com/url?sa=i&url=https%3A%2F%2Fciaelanches.tapper.com.br%2Fx-salada-artesanal&psig=AOvVaw3CK8tt4IjoyKotC_IYxSZA&ust=1716936982510000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCOCDu-32roYDFQAAAAAdAAAAABAE','https://www.google.com/url?sa=i&url=https%3A%2F%2Fciaelanches.tapper.com.br%2Fx-salada-artesanal&psig=AOvVaw3CK8tt4IjoyKotC_IYxSZA&ust=1716936982510000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCOCDu-32roYDFQAAAAAdAAAAABAE', 1, 1, 2)");
            mb.Sql("Insert into Lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImageUrl, ImageThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) " +
                "values ('Coca-Cola','Coca-Cola 350ml','Coca-Cola em lata de 350ml',5.99,'https://www.google.com/url?sa=i&url=https%3A%2F%2Fpizzaria.eriklima.me%2Fproduto%2Fcoca-cola-300ml%2F&psig=AOvVaw2w1Kn0MJH331dr8FLsM7gy&ust=1716937377728000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCPjs7a74roYDFQAAAAAdAAAAABAE','https://www.google.com/url?sa=i&url=https%3A%2F%2Fpizzaria.eriklima.me%2Fproduto%2Fcoca-cola-300ml%2F&psig=AOvVaw2w1Kn0MJH331dr8FLsM7gy&ust=1716937377728000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCPjs7a74roYDFQAAAAAdAAAAABAE', 1, 1, 1)");
            mb.Sql("Insert into Lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImageUrl, ImageThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) " +
                "values ('Batata Frita','Batata Frita Média','Batata selecionada, cortadas em forma de palito e frita em uma quantidade média',4.99,'https://www.google.com/url?sa=i&url=https%3A%2F%2Fshopee.com.br%2FEmbalagem-Batata-Frita-M%25C3%25A9dia-100Unid.-Branca-i.493099601.21815237734&psig=AOvVaw28Yj2UHHs6jMUEAcaNvPuS&ust=1716937769181000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCIiL1uL5roYDFQAAAAAdAAAAABAE','https://www.google.com/url?sa=i&url=https%3A%2F%2Fshopee.com.br%2FEmbalagem-Batata-Frita-M%25C3%25A9dia-100Unid.-Branca-i.493099601.21815237734&psig=AOvVaw28Yj2UHHs6jMUEAcaNvPuS&ust=1716937769181000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCIiL1uL5roYDFQAAAAAdAAAAABAE', 1, 1, 3)");
            mb.Sql("Insert into Lanches(Nome, DescricaoCurta, DescricaoDetalhada, Preco, ImageUrl, ImageThumbnailUrl, IsLanchePreferido, EmEstoque, CategoriaId) " +
                "values ('Mousse de Maracuja','Mousse de Maracuja 150g','Sobremesa leve e arejada, feita com a polpa fresca do maracujá, creme de leite e um toque de gelatina. Com um sabor tropical e refrescante, essa mousse é perfeita para finalizar a refeição com doçura e suavidade.',6.99,'https://www.google.com/imgres?q=imagens%20de%20mousse%20de%20maracuja%20como%20venda%20de%20sobremesa&imgurl=https%3A%2F%2Fguiadacozinha.com.br%2Fwp-content%2Fuploads%2F2019%2F11%2FMousse-de-maracuja-com-cachaca.jpg&imgrefurl=https%3A%2F%2Fguiadacozinha.com.br%2Freceitas%2Fmousse-de-maracuja-com-cachaca%2F&docid=lfxSbf_WdRhMXM&tbnid=eY_wJTRC685XJM&vet=12ahUKEwjqw4aa-q6GAxUhqpUCHdPvCHcQM3oFCIMBEAA..i&w=750&h=500&hcb=2&ved=2ahUKEwjqw4aa-q6GAxUhqpUCHdPvCHcQM3oFCIMBEAA','https://www.google.com/imgres?q=imagens%20de%20mousse%20de%20maracuja%20como%20venda%20de%20sobremesa&imgurl=https%3A%2F%2Fguiadacozinha.com.br%2Fwp-content%2Fuploads%2F2019%2F11%2FMousse-de-maracuja-com-cachaca.jpg&imgrefurl=https%3A%2F%2Fguiadacozinha.com.br%2Freceitas%2Fmousse-de-maracuja-com-cachaca%2F&docid=lfxSbf_WdRhMXM&tbnid=eY_wJTRC685XJM&vet=12ahUKEwjqw4aa-q6GAxUhqpUCHdPvCHcQM3oFCIMBEAA..i&w=750&h=500&hcb=2&ved=2ahUKEwjqw4aa-q6GAxUhqpUCHdPvCHcQM3oFCIMBEAA', 1, 1, 4)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Lanches");
        }
    }
}
