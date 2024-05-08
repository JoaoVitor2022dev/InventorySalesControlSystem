using ControleVendasEstoque.br.com.projeto.dao;
using ControleVendasEstoque.br.com.projeto.model;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ControleVendasEstoque.br.com.projeto.view
{
    public partial class Frmclientes : Form
    {
        public Frmclientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();

            obj.name = txtnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.complemento = txtcomplemento.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = txtuf.Text;

            ClienteDAO dao = new ClienteDAO();
            dao.CadastrarCliente(obj);

            tabClientes.SelectedTab = tabPage2;

            // atualizar os dados do banco de dados 
            TabelaCliente.DataSource = dao.listarClientes();

            new Helpers().LimparTela(this);
            txtuf.SelectedIndex = -1; 
        }

        private void btndeletar_Click(object sender, EventArgs e)
        {
            // deletar cliente 

            Cliente obj = new Cliente();

            // pegar o codigo 
            obj.codigo = int.Parse(txtcodigo.Text);

            ClienteDAO dao = new ClienteDAO(); 

            dao.ExcluirCliente(obj);

            // atualizar os dados do banco de dados 
            TabelaCliente.DataSource = dao.listarClientes();

            tabClientes.SelectedTab = tabPage2;

            new Helpers().LimparTela(this);
            
        }

        private void txteditar_Click(object sender, EventArgs e)
        {
            Cliente obj = new Cliente();

            obj.name = txtnome.Text;
            obj.rg = txtrg.Text;
            obj.cpf = txtcpf.Text;
            obj.email = txtemail.Text;
            obj.telefone = txttelefone.Text;
            obj.celular = txtcelular.Text;
            obj.cep = txtcep.Text;
            obj.endereco = txtendereco.Text;
            obj.numero = int.Parse(txtnumero.Text);
            obj.complemento = txtcomplemento.Text;
            obj.bairro = txtbairro.Text;
            obj.cidade = txtcidade.Text;
            obj.estado = txtuf.SelectedItem.ToString();
            obj.codigo = int.Parse(txtcodigo.Text);

            ClienteDAO dao = new ClienteDAO();
            dao.CadastrarCliente(obj);

            tabClientes.SelectedTab = tabPage2;

            // atualizar os dados do banco de dados 
            TabelaCliente.DataSource = dao.listarClientes();

            new Helpers().LimparTela(this);
        }

        private void txtcep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtcomplementos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuf_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Frmclientes_Load(object sender, EventArgs e)
        {
            TabelaCliente.DefaultCellStyle.ForeColor = Color.Black; 
            ClienteDAO dao = new ClienteDAO();
            TabelaCliente.DataSource = dao.listarClientes();
        }

        private void TabelaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = TabelaCliente.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = TabelaCliente.CurrentRow.Cells[1].Value.ToString();
            txtrg.Text = TabelaCliente.CurrentRow.Cells[2].Value.ToString();
            txtcpf.Text = TabelaCliente.CurrentRow.Cells[3].Value.ToString();
            txtemail.Text = TabelaCliente.CurrentRow.Cells[4].Value.ToString();
            txttelefone.Text = TabelaCliente.CurrentRow.Cells[5].Value.ToString();
            txtcelular.Text = TabelaCliente.CurrentRow.Cells[6].Value.ToString();
            txtcep.Text = TabelaCliente.CurrentRow.Cells[7].Value.ToString();
            txtendereco.Text = TabelaCliente.CurrentRow.Cells[8].Value.ToString();
            txtnumero.Text = TabelaCliente.CurrentRow.Cells[9].Value.ToString();
            txtcomplemento.Text = TabelaCliente.CurrentRow.Cells[10].Value.ToString();
            txtbairro.Text = TabelaCliente.CurrentRow.Cells[11].Value.ToString();
            txtcidade.Text = TabelaCliente.CurrentRow.Cells[12].Value.ToString();
            txtuf.Text = TabelaCliente.CurrentRow.Cells[13].Value.ToString();

            tabClientes.SelectedTab = tabPage1; 
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtpesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtconsulta.Text;

            ClienteDAO dao = new ClienteDAO();

            TabelaCliente.DataSource = dao.BuscarClientePorNome(nome);

            if (TabelaCliente.Rows.Count == 0)
            {
                TabelaCliente.DataSource = dao.listarClientes();
            }
        }

        private void txtconsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txtconsulta.Text + "%";

            ClienteDAO dao = new ClienteDAO();

            TabelaCliente.DataSource = dao.ListarClientePorNome(nome);
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

        private void txtendereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
