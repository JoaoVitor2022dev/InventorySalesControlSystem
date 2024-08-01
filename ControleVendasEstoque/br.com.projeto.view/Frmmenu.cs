using System;
using System.Windows.Forms;

namespace ControleVendasEstoque.br.com.projeto.view
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            txtdata.Text = DateTime.Now.ToShortDateString();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //prgramando dentro do timer
            // pegando as horas 
            txthora.Text = DateTime.Now.ToLongTimeString();

        }

        private void txtmenuclientecadastrar_Click(object sender, EventArgs e)
        {
            // Gerar a tela de Cadastrar cliente 
            Frmclientes Tela = new Frmclientes();
            Tela.ShowDialog(); 
        }

        private void txtmenuclienteconsulta_Click(object sender, EventArgs e)
        {
            // Gerar a tela de Cadastrar cliente 
            Frmclientes Tela = new Frmclientes();
            Tela.tabClientes.SelectedTab = Tela.tabPage2;

            Tela.ShowDialog();
        }

        private void txtmenuFuncionarioCadastrar_Click(object sender, EventArgs e)
        {
            // Gerar a tela de Cadastrar cliente 
            FrmFuncionarios Tela = new FrmFuncionarios();
            Tela.ShowDialog();
        }

        private void txtmenufuncionarioconsulta_Click(object sender, EventArgs e)
        {
            // Gerar a tela de Cadastrar Funcionario
            FrmFuncionarios Tela = new FrmFuncionarios();
            Tela.tabFuncionario.SelectedTab = Tela.tabPage2;
            Tela.ShowDialog();
        }

        private void txtmenuFornecedorCadastrar_Click(object sender, EventArgs e)
        {
            // Gerar Fila de Cadastrar Fornecedor
            FrmFornecedor Tela = new FrmFornecedor();
            Tela.ShowDialog();
        }

        private void txtmenuFornecedorConsulta_Click(object sender, EventArgs e)
        {
            // Gerar Fila de Cadastrar Fornecedor
            FrmFornecedor Tela = new FrmFornecedor();
            Tela.tabFornecedor.SelectedTab = Tela.tabPage2; 
            Tela.ShowDialog();
        }

        private void txtmenuProdutoCadastrar_Click(object sender, EventArgs e)
        {
            // Gerar Fila de Cadastrar Fornecedor
            FrmProduto Tela = new FrmProduto();
            Tela.ShowDialog();
        }

        private void txtmenuProdutoConsultar_Click(object sender, EventArgs e)
        {
            // Gerar Fila de Cadastrar Fornecedor
            FrmProduto Tela = new FrmProduto();
            Tela.tabProdutos.SelectedTab = Tela.tabPage2;
            Tela.ShowDialog();
        }

        private void txtmenuNovaVenda_Click(object sender, EventArgs e)
        {
            // Gerar Fila de Cadastrar Fornecedor
            FrmVendas Tela = new FrmVendas();
            Tela.ShowDialog();
        }

        private void txtmenuHistoricoVenda_Click(object sender, EventArgs e)
        {
            // Gerar Fila de Cadastrar Fornecedor
            FrmHistorico Tela = new FrmHistorico();   
            Tela.ShowDialog();
        }
    }
}
