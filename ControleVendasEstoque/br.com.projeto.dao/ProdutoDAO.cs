using ControleVendasEstoque.br.com.projeto.conexao;
using ControleVendasEstoque.br.com.projeto.model;
using MySql.Data.MySqlClient;
using System;
using System.Data;
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

        #region Metodo de Alterar Produto 
        public void AlterarProduto(Produto obj)
        {
            try
            {
                string sql = "UPDATE tb_produtos SET descricao = @descricao, preco = @preco, qtd_estoque = @qtd, for_id = @for_id WHERE id = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", obj.Descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.Preco);
                executacmd.Parameters.AddWithValue("@qtd", obj.Qtdestoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);
                executacmd.Parameters.AddWithValue("@id", obj.Id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto Alterado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro " + erro);
            }
        }
        #endregion

        #region Metodo de apagar Produto
        public void DeletarProduto(Produto obj)
        {
            try
            {
                string sql = "DELETE FROM tb_produtos WHERE id = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.Id);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto Deletado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro " + erro);
            }
        }
        #endregion

        #region Metodo que listar os produtos por nome 
        public DataTable listarProdutosPorNome(string nome)
        {
            try
            {
                // 1 - Create a DataTable to hold the product data
                DataTable tabelaProduto = new DataTable();

                // SQL query to select products by name
                string sql = @"SELECT 
                          tb_produtos.id AS 'Código', 
                          tb_produtos.descricao AS 'Descrição',
                          tb_produtos.qtd_estoque AS 'Qtd Estoque', 
                          tb_produtos.preco AS 'Preço',
                          tb_fornecedores.nome AS 'Fornecedor'
                       FROM 
                          tb_produtos
                       JOIN 
                          tb_fornecedores ON tb_produtos.for_id = tb_fornecedores.id  
                       WHERE 
                          tb_produtos.descricao LIKE @nome;";

                // 2 - Organize the SQL command
                using (MySqlCommand executacmd = new MySqlCommand(sql, conexao))
                {
                    executacmd.Parameters.AddWithValue("@nome", "%" + nome + "%");

                    // 3 - Create MySqlDataAdapter to fill the DataTable
                    using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executacmd))
                    {
                        // Open the connection
                        conexao.Open();

                        // Fill the DataTable with the data from the query
                        dataAdapter.Fill(tabelaProduto);

                        // Close the connection
                        conexao.Close();
                    }
                }

                return tabelaProduto;
            }
            catch (Exception error)
            {
                MessageBox.Show("Erro ao executar o comando SQL: " + error.Message);
                return null;
            }
        }

        #endregion

        #region Metodo que busca os produtos por nome 
        public DataTable buscarProdutosPorNome(string nome)
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
                            tb_fornecedores ON tb_produtos.for_id = tb_fornecedores.id  
                            WHERE tb_produtos.descricao = @nome;";

                // 2 - organizar o comando sql no executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
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

        #region Método que retornar produto por codigo 
        public Produto RetornaProdutoPerCodigo(int id) 
        {
            try
            {
                // 1 - comando sql 

                string sql = @"SELECT * FROM tb_produtos WHERE id = @id"; 

                MySqlCommand executedcmd = new MySqlCommand(sql, conexao);
                executedcmd.Parameters.AddWithValue("@id", id);

                MySqlDataReader reader = executedcmd.ExecuteReader();

                if (reader.Read())
                {
                    Produto produto = new Produto();

                    produto.Id = reader.GetInt32("id"); 
                    produto.Descricao = reader.GetString("descricao");
                    produto.Preco = reader.GetDecimal("preco");

                    return produto;
                } 
                else
                {
                    MessageBox.Show("Nenhum produto encontrado com esse codigo");
                    return null; 
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Aconteceu o erro: " + err);
                return null; 
            }
        }
        #endregion
    }
}
