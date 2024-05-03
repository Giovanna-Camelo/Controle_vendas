using System.ComponentModel.DataAnnotations;

namespace Vendas.Models
{
    public class Funcionario
    {
        public int funcionarioID { get; set; }

        [Display(Name = "Nome do Funcionário")]
        [Required]
        public string? Nome { get; set; }

        public decimal salário { get; set; }

    }
}
