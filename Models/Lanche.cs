using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace Lanches_Online.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage = "Informe o nome do Lanche.")]
        [StringLength(80)]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Informe a descrição curta do Lache.")]
        [StringLength(80)]
        public string? DescricaoCurta { get; set; }

        [Required(ErrorMessage = "Informe a descrição detalhada do Lache.")]
        [StringLength(300)]
        public string? DescricaoDetalhada { get; set; }

        [Required(ErrorMessage ="Informe o Preço")]
        [Column(TypeName = "decimal(10,2)")]
        public int Preco { get; set; }

        [Required(ErrorMessage = "Informe a Url da Imagem")]
        [StringLength(300)]
        public string? ImageUrl { get; set; }

        [Required(ErrorMessage = "Informe a Url da Imagem")]
        [StringLength(300)]
        public string? ImageThumbnailUrl { get; set; }

        public bool IsLanchePreferido { get; set; }
        public bool EmEstoque { get; set; }
        public int CategoriaId { get; set; }

        [NotMapped]
        public DataSetDateTime DataDeCriacao { get; set; }

        public virtual Categoria? Categoria { get; set; }
    }
}
