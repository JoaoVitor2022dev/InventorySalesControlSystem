using ControleVendasEstoque.br.com.projeto.conexao;
using ControleVendasEstoque.br.com.projeto.model;
using MySql.Data.MySqlClient;
using Mysqlx;
using System;
using System.Data;
using System.Windows.Forms;

namespace ControleVendasEstoque.br.com.projeto.dao
{
    internal class ClienteDAO
    {
        private MySqlConnection conexao; 
        public ClienteDAO() 
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Cadastrar cliente 
        public void CadastrarCliente(Cliente obj)
        {
            try 
            {
                // 1 - Definir o CMD sql - insert into
                string sql = @"INSERT INTO tb_clientes (nome, rg, cpf, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado) 
                  VALUES (@nome, @rg, @cpf, @email, @telefone, @celular, @cep, @endereco, @numero, @complemento , @bairro, @cidade, @estado);";

                // 2 -  Organizar o comando sql     
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.name);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
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

                MessageBox.Show("Cliente cadastrado com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um error: " + erro);
            }
        }
        #endregion

        #region AlterarCliente
        public void AlterarCliente(Cliente obj)
        {
            try
            {
                // 1 - Definir o CMD sql - insert into
                string sql = @"UPDATE tb_clientes
                             SET nome=@nome, rg=@rg, cpf=@cpf, email=@email, telefone=@telefone, 
                             celular=@celular, cep=@cep, endereco=@endereco, numero=@numero, 
                             complemento=@complemento, bairro=@bairro, cidade=@cidade, estado=@estado 
                             WHERE id=@id";

                // 2 -  Organizar o comando sql     
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.name);
                executacmd.Parameters.AddWithValue("@rg", obj.rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
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

                // 3 - executar o comando sql 
                conexao.Open();
                executacmd.ExecuteNonQuery();
                
                MessageBox.Show("Cliente Modificado com Sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um error: " + erro);
            }
        }
        #endregion

        #region ExcluirCliente
        public void ExcluirCliente(Cliente obj)
        {
            try
            {
                // 1 - Definir o CMD sql - insert into
                string sql = @"delete from tb_clientes where id = @id"; 

                // 2 -  Organizar o comando sql     
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.codigo);

                // 3 - executar o comando sql 
                conexao.Open();
                executacmd.ExecuteNonQuery();


                MessageBox.Show("Cliente Alterado com Sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu um error: " + erro);
            }
        }
        #endregion

        #region ListarClientes
        public DataTable listarClientes()
        {
            try
            {
                // 1 - passo é criar um datatable com sql 
                DataTable tabelaCliente = new DataTable();
                string sql = "SELECT * FROM tb_clientes;";

                // 2 - organizar o comando sql no executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                conexao.Open();
                executacmd.ExecuteNonQuery();

                // 3 - passo - criar MysqDataApter para preencher os dados no datatable
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executacmd);
                dataAdapter.Fill(tabelaCliente);
                conexao.Close();

                return tabelaCliente; 
            }
            catch (Exception error)
            {

                MessageBox.Show("Error ao executar o comando sql: " + error);
                return null; 
            }
        }
        #endregion

        #region BuscarClientePorNome
        public DataTable BuscarClientePorNome(string nome )  
        {
            try
            {
                // 1 - passo é criar um datatable com sql 
                DataTable tabelaCliente = new DataTable();
                string sql = "SELECT * FROM tb_clientes WHERE nome = @nome;";

                // 2 - organizar o comando sql no executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                    executacmd.Parameters.AddWithValue("@nome", nome); 


                conexao.Open();
                executacmd.ExecuteNonQuery();

                // 3 - passo - criar MysqDataApter para preencher os dados no datatable
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executacmd);
                dataAdapter.Fill(tabelaCliente);
                conexao.Close();

                return tabelaCliente;
            }
            catch (Exception error)
            {

                MessageBox.Show("Error ao executar o comando sql: " + error);
                return null;
            }
        }
        #endregion

        #region ListarClientePorNome
        public DataTable ListarClientePorNome(string nome)
        {
            try
            {
                // 1 - passo é criar um datatable com sql 
                DataTable tabelaCliente = new DataTable();
                string sql = "SELECT * FROM tb_clientes WHERE nome LIKE @nome;";

                // 2 - organizar o comando sql no executar 
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);


                conexao.Open();
                executacmd.ExecuteNonQuery();

                // 3 - passo - criar MysqDataApter para preencher os dados no datatable
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executacmd);
                dataAdapter.Fill(tabelaCliente);
                conexao.Close();

                return tabelaCliente;
            }
            catch (Exception error)
            {

                MessageBox.Show("Error ao executar o comando sql: " + error);
                return null;
            }
        }
        #endregion

        #region Metodo que retorna um cliente por cpf
        public Cliente RetornaClientePorCpf(string cpf)
        {
            try
            {
                Cliente obj = new Cliente();

                // criar o comando sql 
                string sql = @"SELECT * FROM tb_clientes WHERE cpf = @cpf";

                MySqlCommand executedcmd = new MySqlCommand(sql, conexao);
                executedcmd.Parameters.AddWithValue("@cpf", cpf);

                conexao.Open();

                MySqlDataReader reader = executedcmd.ExecuteReader();

                if (reader.Read())
                {
                    obj.codigo = reader.GetInt32("Id");
                    obj.name = reader.GetString("nome");
                }
                else
                {
                    MessageBox.Show("Cliente não encontrado!");
                    conexao.Close();
                    return null;
                }
                conexao.Close();

                return obj;
            }
            catch (Exception error)
            {
                MessageBox.Show("Aconteceu um erro: " + error);
                conexao.Close();
                return null;
            }
        }
        #endregion
    }
}