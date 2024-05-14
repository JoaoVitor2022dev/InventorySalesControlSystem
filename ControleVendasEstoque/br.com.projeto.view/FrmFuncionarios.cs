using ControleVendasEstoque.br.com.projeto.dao;
using ControleVendasEstoque.br.com.projeto.model;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ControleVendasEstoque.br.com.projeto.view
{
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void label19_Click(object sender, EventArgs e)
        {
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
             // salvar 
             Funcionario obj = new Funcionario();

            // receber os dados dos campos 

            obj.name = txtnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.senha = txtsenha.Text;  
            obj.nivelAcesso = txtnivel.SelectedItem.ToString();
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.complemento = txtcomplemento.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = txtuf.SelectedItem.ToString(); 
            obj.cargo = cbcargos.SelectedItem.ToString();

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.cadastrarFuncionario(obj);

            TabelaFuncionarios.DataSource = dao.listarFuncionarios();
        }

        private void btndeletar_Click(object sender, EventArgs e)
        {
            Funcionario obj = new Funcionario(); 

            obj.codigo = int.Parse(txtcodigo.Text);

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.DeletarFuncionario(obj);

            // atualizar a lista de dados 
            TabelaFuncionarios.DataSource = dao.listarFuncionarios(); 
        }

        private void txteditar_Click(object sender, EventArgs e)
        {
            // editar 
            Funcionario obj = new Funcionario();

            // receber os dados dos campos 

            obj.name = txtnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.senha = txtsenha.Text;
            obj.nivelAcesso = txtnivel.SelectedItem.ToString();
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.complemento = txtcomplemento.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = txtuf.SelectedItem.ToString();
            obj.cargo = cbcargos.SelectedItem.ToString();
            obj.codigo = int.Parse(txtcodigo.Text);

            FuncionarioDAO dao = new FuncionarioDAO();
            dao.alterarFuncionario(obj);

            TabelaFuncionarios.DataSource = dao.listarFuncionarios();

            tabFuncionario.SelectedTab = tabPage2;
        }

        private void txtpesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtconsulta.Text;

            FuncionarioDAO dao = new FuncionarioDAO(); 
            TabelaFuncionarios.DataSource= dao.buscarFuncionarioPorNome(nome);

            if (TabelaFuncionarios.Rows.Count == 0 || txtpesquisar.Text == string.Empty)
            {
                MessageBox.Show("Funcionário não econtrado.");
                TabelaFuncionarios.DataSource = dao.listarFuncionarios();
            }
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {
        }

        private void TabelaFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void cbcargos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void TabelaFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = TabelaFuncionarios.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = TabelaFuncionarios.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text = TabelaFuncionarios.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text = TabelaFuncionarios.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = TabelaFuncionarios.CurrentRow.Cells[4].Value.ToString();
            txtsenha.Text = TabelaFuncionarios.CurrentRow.Cells[5].Value.ToString();
            cbcargos.Text = TabelaFuncionarios.CurrentRow.Cells[6].Value.ToString();
            txtnivel.Text = TabelaFuncionarios.CurrentRow.Cells[7].Value.ToString();
            txttelefone.Text = TabelaFuncionarios.CurrentRow.Cells[8].Value.ToString();
            txtcelular.Text = TabelaFuncionarios.CurrentRow.Cells[9].Value.ToString();
            txtcep.Text = TabelaFuncionarios.CurrentRow.Cells[10].Value.ToString();
            txtendereco.Text = TabelaFuncionarios.CurrentRow.Cells[11].Value.ToString();
            txtnumero.Text = TabelaFuncionarios.CurrentRow.Cells[12].Value.ToString();
            txtcomplemento.Text = TabelaFuncionarios.CurrentRow.Cells[13].Value.ToString();
            txtbairro.Text = TabelaFuncionarios.CurrentRow.Cells[14].Value.ToString();
            txtcidade.Text = TabelaFuncionarios.CurrentRow.Cells[15].Value.ToString();
            txtuf.Text = TabelaFuncionarios.CurrentRow.Cells[16].Value.ToString();

            tabFuncionario.SelectedTab = tabPage1;
        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            TabelaFuncionarios.DefaultCellStyle.ForeColor = Color.Black;
            FuncionarioDAO dao = new FuncionarioDAO();
            TabelaFuncionarios.DataSource = dao.listarFuncionarios();
        }

        private void txtconsulta_TextChanged(object sender, EventArgs e)
        {
            string nome = "%" + txtconsulta.Text + "%";

            FuncionarioDAO dao = new FuncionarioDAO();

            TabelaFuncionarios.DataSource = dao.listarFuncionarioPorNome(nome); 
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = txtcep.Text;

                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet();

                dados.ReadXml(xml);

                txtendereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtbairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtcidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txtuf.Text = dados.Tables[0].Rows[0]["uf"].ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Endereço não encontrado, por favor digite manualmente.");
            }
        }
    }
}
