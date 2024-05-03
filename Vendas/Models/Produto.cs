namespace Vendas.Models
{
    public class Produto
    {
        public int produtoID { get; set; }
        public string? Tipo { get; set; }
        public int Quantidade { get; set; }
        public decimal Preço { get; set; }
    }
}
