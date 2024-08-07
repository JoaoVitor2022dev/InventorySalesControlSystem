﻿using ControleVendasEstoque.br.com.projeto.conexao;
using ControleVendasEstoque.br.com.projeto.model;
using MySql.Data.MySqlClient;
using System;
using System.Data;
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

        #region Metodo que lista todos os itens por venda 
        public DataTable ListarItensPorVenda(int id_venda)
        {
            try
            {
                //  criar um data table
                DataTable TabelaItens = new DataTable();


                // criar um comando SQL 
                string sql = @"SELECT i.id        AS 'Código',
                                      p.descricao AS 'Descrição', 
                                      i.qtd       AS 'Quantidade', 
                                      p.preco     AS 'Preço',
                                      i.subtotal  AS 'SubTotal'
                               FROM 
                                      tb_itensvendas AS i
                               JOIN 
                                      tb_produtos AS p
                                 ON 
                                      i.produto_id = p.id
                              WHERE 
                                      i.venda_id = @venda_id;";

                // execuatr o comando sql 
                MySqlCommand executecmdsql = new MySqlCommand(sql, conexao);
                executecmdsql.Parameters.AddWithValue("@venda_id", id_venda );
       

                conexao.Open();
                executecmdsql.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executecmdsql);
                da.Fill(TabelaItens);

                return TabelaItens;

            }
            catch (Exception err)
            {
                MessageBox.Show($"Erro ao executar o comando SQL: {err}");
                return null;
            }
        }
        #endregion
    }
}
