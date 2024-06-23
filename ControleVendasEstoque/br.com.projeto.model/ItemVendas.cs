namespace ControleVendasEstoque.br.com.projeto.model
{
    public class ItemVendas
    {
        public int Id { get; set; }
        public int Vendas_Id { get; set; }
        public int Produto_id { get; set; }
        public int Qtd { get; set; }
        public decimal Subtotal  { get; set; }
    }
}
