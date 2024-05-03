namespace Vendas.Models
{
    public class Venda
    {
        public int VendaId { get; set; }
        public int funcionariosID { get; set; }
        public string? Tipo { get; set; }

        public int Quantidade { get; set; }
        public decimal Valor { get; set; }

    }
}
