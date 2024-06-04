using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text.Json.Serialization;

namespace Lanches_Online.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage ="Informe o nome da Categoria.")]
        [StringLength(80)]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Informe a descrição da Categoria.")]
        [StringLength(300)]
        public string? Descricao { get; set; }

        [NotMapped]
        public DataSetDateTime DataDeCriacao { get; set; }

        [JsonIgnore]
        public List<Lanche>? Lanches { get; set;}
    }
}
