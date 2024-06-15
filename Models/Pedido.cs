using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lanches_Online.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }

        [Required(ErrorMessage ="Informe o Nome")]
        [StringLength(50)]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Informe o Sobrenome")]
        [StringLength(50)]
        public string? Sobrenome { get; set; }

        [Required(ErrorMessage = "Informe o Endereço")]
        [StringLength(100)]
        [Display(Name = "Endereço")]
        public string? Endereco1 { get; set; }

        [Required(ErrorMessage = "Informe o Endereço")]
        [StringLength(100)]
        [Display(Name = "Complemento")]
        public string? Endereco2 { get; set; }

        [Required(ErrorMessage = "Informe o seu CEP")]
        [StringLength(10, MinimumLength = 8)]
        [Display(Name = "CEP")]
        public string? Cep { get; set; }

        [StringLength(10)]
        [Required(ErrorMessage = "Informe o seu Estado")]
        public string? Estado { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Informe a sua Cidade")]
        public string? Cidade { get; set; }

        [Required(ErrorMessage = "Informe o seu Telefone")]
        [StringLength(25)]
        [DataType(DataType.PhoneNumber)]
        public string? Telefone { get; set; }

        [Required(ErrorMessage = "Informe seu email")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        /*[RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$)",
        ErrorMessage = "O email não possui um formato correto")]*/
        public string? Email { get; set; }

        [ScaffoldColumn(false)]
        [Column(TypeName = "decimal(12,2)")]
        [Display(Name = "Total do Pedido")]
        public decimal PedidoTotal { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Itens no Pedido")]
        public int TotalItensPedido { get; set; }

        [Display(Name = "Data do Pedido")]
        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm", ApplyFormatInEditMode = true)]
        public DateTime PedidoEnviado { get; set; }

        [Display(Name = "Data Envio Pedido")]
        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm", ApplyFormatInEditMode = true)]
        public DateTime? PedidoEntregueEm { get; set; }


        public List<PedidoDetalhe>? PedidoItens { get; set; }
    }
}
