using ControleVendasEstoque.br.com.projeto.dao;
using ControleVendasEstoque.br.com.projeto.model;
using System;
using System.Data;
using System.Windows.Forms;

namespace ControleVendasEstoque.br.com.projeto.view
{
    public partial class FrmFornecedor : Form
    {
        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();

            obj.name = txtnome.Text;
            obj.cnpj = txtcnpj.Text; 
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

            FornecedorDAO dao = new FornecedorDAO();

            dao.CadastrarFornecedor(obj);

            TabelaFornecedores.DataSource = dao.listarFornecedores();

            tabFornecedor.SelectedTab = tabPage2;

            new Helpers().LimparTela(this);
        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            FornecedorDAO dao = new FornecedorDAO();
            TabelaFornecedores.DataSource = dao.listarFornecedores();   
        }

        private void TabelaFornecedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcodigo.Text = TabelaFornecedores.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = TabelaFornecedores.CurrentRow.Cells[1].Value.ToString();
            txtcnpj.Text = TabelaFornecedores.CurrentRow.Cells[2].Value.ToString();
            txtemail.Text = TabelaFornecedores.CurrentRow.Cells[3].Value.ToString();
            txttelefone.Text = TabelaFornecedores.CurrentRow.Cells[4].Value.ToString();
            txtcelular.Text = TabelaFornecedores.CurrentRow.Cells[5].Value.ToString();
            txtcep.Text = TabelaFornecedores.CurrentRow.Cells[6].Value.ToString();
            txtendereco.Text = TabelaFornecedores.CurrentRow.Cells[7].Value.ToString();
            txtnumero.Text = TabelaFornecedores.CurrentRow.Cells[8].Value.ToString();
            txtcomplemento.Text = TabelaFornecedores.CurrentRow.Cells[9].Value.ToString();
            txtbairro.Text = TabelaFornecedores.CurrentRow.Cells[10].Value.ToString();
            txtcidade.Text = TabelaFornecedores.CurrentRow.Cells[11].Value.ToString();
            txtuf.Text = TabelaFornecedores.CurrentRow.Cells[12].Value.ToString();

            tabFornecedor.SelectedTab = tabPage1;
        }

        private void txteditar_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();

            obj.name = txtnome.Text;
            obj.cnpj = txtcnpj.Text;
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

            FornecedorDAO dao = new FornecedorDAO();

            dao.alterarForncedor(obj);

            TabelaFornecedores.DataSource = dao.listarFornecedores();

            tabFornecedor.SelectedTab = tabPage2;

            new Helpers().LimparTela(this);
        }

        private void btndeletar_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();

            obj.codigo = int.Parse(txtcodigo.Text);

            FornecedorDAO dao = new FornecedorDAO();

            dao.DeletarForncedor(obj);

            TabelaFornecedores.DataSource = dao.listarFornecedores();

            tabFornecedor.SelectedTab = tabPage2;

            new Helpers().LimparTela(this);
        }
    }
}
