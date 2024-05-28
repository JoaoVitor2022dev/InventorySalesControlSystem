using System;

namespace ControleVendasEstoque.br.com.projeto.model
{
    internal class Vendas
    {
        public int Id { get; set; }
        public int cliente_id { get; set; }
        public DateTime Data_vendas { get; set; }
        public decimal Total_vendas { get; set; }
        public string obs { get; set; }
    }
}
