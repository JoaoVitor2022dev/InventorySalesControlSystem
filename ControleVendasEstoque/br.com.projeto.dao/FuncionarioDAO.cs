using ControleVendasEstoque.br.com.projeto.conexao;
using ControleVendasEstoque.br.com.projeto.model;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ControleVendasEstoque.br.com.projeto.dao
{
    public class FuncionarioDAO
    {
        private MySqlConnection conexao;

        public FuncionarioDAO()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }
        #region Cadastrar Funcionario
        public void cadastrarFuncionario(Funcionario obj) 
        {
            try
            {
                string sql = "INSERT INTO tb_funcionarios (nome, rg, cpf, email, senha, cargo, nivel_acesso, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado) " +
                             "VALUES (@nome, @rg, @cpf, @email, @senha, @cargo, @nivel, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado);\r\n";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.name);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executacmd.Parameters.AddWithValue("@nivel", obj.nivelAcesso);
                executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.celular);
                executacmd.Parameters.AddWithValue("@cep", obj.cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.estado);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente cadastrado com sucesso!");
                conexao.Close();
            }
            catch (Exception error)
            {

                MessageBox.Show($"Ocorreu um error: {error}"); 
            }
        }
        #endregion

    }
}
