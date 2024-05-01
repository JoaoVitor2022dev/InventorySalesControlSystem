namespace ControleVendasEstoque.br.com.projeto.model
{
    public class Funcionario : Cliente
    {
        public string Senha { get; set; }
        public string Cargo { get; set; }
        public string NivelAcesso { get; set; }
    }
}
