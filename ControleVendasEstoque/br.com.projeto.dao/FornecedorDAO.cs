﻿using ControleVendasEstoque.br.com.projeto.conexao;
using ControleVendasEstoque.br.com.projeto.model;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;
using System.Data;
using Mysqlx;

namespace ControleVendasEstoque.br.com.projeto.dao
{
    internal class FornecedorDAO
    {
        private MySqlConnection conexao;
        public FornecedorDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }
        #region Cadastrar cliente 
        public void CadastrarFornecedor(Fornecedor obj)
        {
            try
            {
                // 1 - Definir o CMD sql - insert into
                string sql = @"INSERT INTO tb_fornecedores (nome, cnpj, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado) 
                  VALUES (@nome, @cnpj, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento , @bairro, @cidade, @estado);";

                // 2 -  Organizar o comando sql     
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.name);
                executacmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                // 3 - executar o comando sql 
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor cadastrado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um error: " + erro);
            }
        }
        #endregion

        #region Listar Fornecedores 
        public DataTable listarFornecedores()
        {
            try
            {
                // 1 - passo é criar um datatable com sql 
                DataTable tabelaFornecedor = new DataTable();
                string sql = "SELECT * FROM tb_fornecedores;";

                // 2 - organizar o comando sql no executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // 3 - passo - criar MysqDataApter para preencher os dados no datatable
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executacmd);
                dataAdapter.Fill(tabelaFornecedor);
                conexao.Close();

                return tabelaFornecedor;
            }
            catch (Exception error)
            {
                MessageBox.Show("Error ao executar o comando sql: " + error);
                return null;
            }
        }
        #endregion]

        #region Metodo de alterra um Fornecedor 
        public void alterarForncedor(Fornecedor obj) 
        {
            try
            {
                string sql = @"UPDATE tb_fornecedores 
                             SET nome=@nome, cnpj=@cnpj, email=@email,
                             telefone=@telefone, 
                             celular=@celular, cep=@cep, endereco=@endereco, numero=@numero, 
                             complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado 
                             WHERE id=@id";


                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.name);
                executacmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor Alterado com Sucesso!");
                conexao.Close();

            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um error: {error}");
            }
        }
        #endregion

        #region Metodo de excluir Fornecedor 
        public void DeletarForncedor(Fornecedor obj)
        {
            try
            {
                string sql = @"DELETE FROM tb_fornecedores WHERE id = @id ";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor Deletado com sucesso!");
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um error: " + erro );
            }
        }
        #endregion

        #region Listar Fornecedor por nome 
        public DataTable listarFornecedoresPorNome(string nome)
        {
            try
            {
                // 1 - passo é criar um datatable com sql 
                DataTable tabelaFornecedor = new DataTable();
                string sql = "SELECT * FROM tb_fornecedores WHERE nome Like @nome;";

                // 2 - organizar o comando sql no executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // 3 - passo - criar MysqDataApter para preencher os dados no datatable
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executacmd);
                dataAdapter.Fill(tabelaFornecedor);
                conexao.Close();

                return tabelaFornecedor;
            }
            catch (Exception error)
            {
                MessageBox.Show("Error ao executar o comando sql: " + error);
                return null;
            }
        }
        #endregion

        #region Buscar Fornecedor por nome 
        public DataTable BuscarFornecedoresPorNome(string nome)
        {
            try
            {
                // 1 - passo é criar um datatable com sql 
                DataTable tabelaFornecedor = new DataTable();
                string sql = "SELECT * FROM tb_fornecedores WHERE nome = @nome;";

                // 2 - organizar o comando sql no executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // 3 - passo - criar MysqDataApter para preencher os dados no datatable
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executacmd);
                dataAdapter.Fill(tabelaFornecedor);
                conexao.Close();

                return tabelaFornecedor;
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
