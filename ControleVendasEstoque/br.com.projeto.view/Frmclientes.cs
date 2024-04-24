using ControleVendasEstoque.br.com.projeto.dao;
using ControleVendasEstoque.br.com.projeto.model;
using System;
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

            txtnome.Clear();
            txtrg.Clear();
            txtcpf.Clear();
            txtemail.Clear();
            txttelefone.Clear();
            txtcelular.Clear();
            txtcep.Clear();
            txtendereco.Clear();
            txtnumero.Clear();
            txtcomplemento.Clear();
            txtbairro.Clear();
            txtcidade.Clear(); 
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

            txtcodigo.Clear();
            txtnome.Clear();
            txtrg.Clear();
            txtcpf.Clear();
            txtemail.Clear();
            txttelefone.Clear();
            txtcelular.Clear();
            txtcep.Clear();
            txtendereco.Clear();
            txtnumero.Clear();
            txtcomplemento.Clear();
            txtbairro.Clear();
            txtcidade.Clear();
            txtuf.SelectedIndex = -1;
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
            obj.estado = txtuf.Text;
            obj.codigo = int.Parse(txtcodigo.Text);

            ClienteDAO dao = new ClienteDAO();
            dao.CadastrarCliente(obj);

            tabClientes.SelectedTab = tabPage2;

            // atualizar os dados do banco de dados 
            TabelaCliente.DataSource = dao.listarClientes();

            txtnome.Clear();
            txtrg.Clear();
            txtcpf.Clear();
            txtemail.Clear();
            txttelefone.Clear();
            txtcelular.Clear();
            txtcep.Clear();
            txtendereco.Clear();
            txtnumero.Clear();
            txtcomplemento.Clear();
            txtbairro.Clear();
            txtcidade.Clear();
            txtuf.SelectedIndex = -1;
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
            txtemail.Text = TabelaCliente.CurrentRow.Cells[3].Value.ToString();
            txttelefone.Text = TabelaCliente.CurrentRow.Cells[4].Value.ToString();
            txtcelular.Text = TabelaCliente.CurrentRow.Cells[5].Value.ToString();
            txtcep.Text = TabelaCliente.CurrentRow.Cells[6].Value.ToString();
            txtendereco.Text = TabelaCliente.CurrentRow.Cells[7].Value.ToString();
            txtnumero.Text = TabelaCliente.CurrentRow.Cells[8].Value.ToString();
            txtcomplemento.Text = TabelaCliente.CurrentRow.Cells[9].Value.ToString();
            txtbairro.Text = TabelaCliente.CurrentRow.Cells[10].Value.ToString();
            txtcidade.Text = TabelaCliente.CurrentRow.Cells[11].Value.ToString();
            txtendereco.Text = TabelaCliente.CurrentRow.Cells[12].Value.ToString();
            txtuf.Text = TabelaCliente.CurrentRow.Cells[13].Value.ToString();

            tabClientes.SelectedTab = tabPage1; 
        }
    }
}
