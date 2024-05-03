using System.ComponentModel.DataAnnotations;

namespace Controle_Vendas.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string? Name { get; set; }
        public int telefone { get; set; }
        public int CPF { get; set; }
        public string? Email { get; set; }

        public string? endereco { get; set; }
        [Display(Name = "Numero da residência ")]
        public int numero { get; set; }
        [Display(Name = "Complemento")]
        public string? comp { get; set; }
        public int cep { get; set; } 
    }
}
