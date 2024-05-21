using ControleVendasEstoque.br.com.projeto.conexao;
using ControleVendasEstoque.br.com.projeto.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleVendasEstoque.br.com.projeto.dao
{
    internal class ProdutoDAO
    {
        private MySqlConnection conexao;
        public ProdutoDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Cadastrar Produtos 
        public void CadastrodeProduto(Produto obj) 
        {
            try
            {
                string sql = "INSERT INTO tb_produtos (descricao, preco, qtd_estoque, for_id ) " +
                             "VALUES (@descricao, @preco, @qtd , @for_id  );";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", obj.Descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.Preco);
                executacmd.Parameters.AddWithValue("@qtd", obj.Qtdestoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro " + erro); 
            }
        }
        #endregion

        #region Metodo de ListarProdutos
        public DataTable listarProdutos()
        {
            try
            {
                // 1 - passo é criar um datatable com sql 
                DataTable tabelaProduto = new DataTable();
                string sql = @"SELECT 
                            tb_produtos.id AS ""Código"", 
                            tb_produtos.descricao AS ""Descrição"",
                            tb_produtos.qtd_estoque AS ""Qtd Estoque"", 
                            tb_produtos.preco AS ""Preço"",
                            tb_fornecedores.nome AS ""Fornecedor""
                            FROM 
                            tb_produtos
                            JOIN 
                            tb_fornecedores ON tb_produtos.for_id = tb_fornecedores.id;";

                // 2 - organizar o comando sql no executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // 3 - passo - criar MysqDataApter para preencher os dados no datatable
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executacmd);
                dataAdapter.Fill(tabelaProduto);
                conexao.Close();

                return tabelaProduto;
            }
            catch (Exception error)
            {

                MessageBox.Show("Error ao executar o comando sql: " + error);
                return null;
            }
        }
        #endregion
    }
}
