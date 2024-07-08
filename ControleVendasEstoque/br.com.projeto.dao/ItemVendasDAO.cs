using ControleVendasEstoque.br.com.projeto.conexao;
using ControleVendasEstoque.br.com.projeto.model;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ControleVendasEstoque.br.com.projeto.dao
{
     public class ItemVendasDAO
    {
        private MySqlConnection conexao;
        public ItemVendasDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Metodo de cadastrar item de venda 
        public void CadastrarItemdeVenda(ItemVendas obj)
        {
            try
            {
                string sql = @"INSERT INTO tb_itensvendas (venda_id, produto_id, qtd,subtotal)
                               VALUES (@venda_id, @produto_id, @qtd, @subtotal)";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@venda_id", obj.Vendas_Id);
                executacmd.Parameters.AddWithValue("@produto_id", obj.Produto_id);
                executacmd.Parameters.AddWithValue("@qtd", obj.Qtd);
                executacmd.Parameters.AddWithValue("@subtotal", obj.Subtotal);

                // 3 - executar o comando sql 
                conexao.Open();
                executacmd.ExecuteNonQuery();

                conexao.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ocorreu um erro: {err}");
            }
        }
        #endregion


    }
}
