namespace ControleVendasEstoque.br.com.projeto.model
{
    public class Funcionario : Cliente
    {
        public string senha { get; set; }
        public string cargo { get; set; }
        public string nivelAcesso { get; set; }
    }
}