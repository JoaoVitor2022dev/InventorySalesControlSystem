using ControleVendasEstoque.br.com.projeto.conexao;
using ControleVendasEstoque.br.com.projeto.model;
using MySql.Data.MySqlClient;
using System;
using System.Data;
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

        #region Listar Funcionarios
        public DataTable listarFuncionarios()
        {
            try
            {
                // 1 - passo é criar um datatable com sql 
                DataTable tabelaFuncionario = new DataTable();
                string sql = "SELECT * FROM tb_funcionarios;";

                // 2 - organizar o comando sql no executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // 3 - passo - criar MysqDataApter para preencher os dados no datatable
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executacmd);
                dataAdapter.Fill(tabelaFuncionario);
                conexao.Close();


                return tabelaFuncionario;
            }
            catch (Exception error)
            {

                MessageBox.Show("Error ao executar o comando sql: " + error);
                return null;
            }
        }
        #endregion

        #region Alterar Funcionario
        public void alterarFuncionario(Funcionario obj) 
        {
            try
            {
                string sql = @"UPDATE tb_funcionarios 
                             SET nome=@nome, rg=@rg, cpf=@cpf, email=@email, senha=@senha, 
                             cargo=@cargo, nivel_acesso=@nivel, telefone=@telefone, 
                             celular=@celular, cep=@cep, endereco=@endereco, numero=@numero, 
                             complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado 
                             WHERE id=@id";


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
                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Cliente Alterado com sucesso!");
                conexao.Close();
            }
            catch (Exception error)
            {

                MessageBox.Show($"Ocorreu um error: {error}");
            }
        }
        #endregion

        #region Deletar Funcionario
        public void DeletarFuncionario(Funcionario obj)
        {
            try
            {
                string sql = "DELETE FROM tb_funcionarios WHERE id = @id";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Deletado com sucesso com sucesso!");
                conexao.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ocorreu um error: {error}");
            }
        }
        #endregion

        #region Buscar Funcionario por Nome
        public DataTable buscarFuncionarioPorNome(string nome)
        {
            try
            {
                // 1 - passo é criar um datatable com sql 
                DataTable tabelaFuncionario = new DataTable();
                string sql = "SELECT * FROM tb_funcionarios WHERE nome= @nome;";

                // 2 - organizar o comando sql no executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome); 
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // 3 - passo - criar MysqDataApter para preencher os dados no datatable
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executacmd);
                dataAdapter.Fill(tabelaFuncionario);
                conexao.Close();

                return tabelaFuncionario;
            }
            catch (Exception error)
            {

                MessageBox.Show("Error ao executar o comando sql: " + error);
                return null;
            }
        }
        #endregion

        #region Listar Funcionario por nome 
        public DataTable listarFuncionarioPorNome(string nome)
        {
            try
            {
                // 1 - passo é criar um datatable com sql 
                DataTable tabelaFuncionario = new DataTable();
                string sql = "SELECT * FROM tb_funcionarios WHERE nome LIKE @nome;";

                // 2 - organizar o comando sql no executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // 3 - passo - criar MysqDataApter para preencher os dados no datatable
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executacmd);
                dataAdapter.Fill(tabelaFuncionario);
                conexao.Close();

                return tabelaFuncionario;
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
