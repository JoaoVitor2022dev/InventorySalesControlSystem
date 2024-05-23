using ControleVendasEstoque.br.com.projeto.dao;
using ControleVendasEstoque.br.com.projeto.model;
using System;
using System.Windows.Forms;

namespace ControleVendasEstoque.br.com.projeto.view
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            FornecedorDAO fornecedor = new FornecedorDAO(); 

            cbfornecedor.DataSource = fornecedor.listarFornecedores();
            cbfornecedor.DisplayMember = "nome";
            cbfornecedor.ValueMember = "id";

            ProdutoDAO dao = new ProdutoDAO();

            TabelaProdutos.DataSource = dao.listarProdutos();
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            obj.Descricao = txtdesc.Text;
            obj.Preco = decimal.Parse(textpreco.Text);
            obj.Qtdestoque = int.Parse(txtqtd.Text);
            obj.for_id = int.Parse(cbfornecedor.SelectedValue.ToString()); 

            ProdutoDAO dao = new ProdutoDAO();  

            dao.CadastrodeProduto(obj);

            new Helpers().LimparTela(this);

            TabelaProdutos.DataSource = dao.listarProdutos();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            new Helpers().LimparTela(this);
        }

        private void TabelaProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Pegando os dados de um intem selecionado 
            txtcodigo.Text = TabelaProdutos.CurrentRow.Cells[0].Value.ToString();
            txtdesc.Text = TabelaProdutos.CurrentRow.Cells[1].Value.ToString();
            txtqtd.Text = TabelaProdutos.CurrentRow.Cells[2].Value.ToString();
            textpreco.Text = TabelaProdutos.CurrentRow.Cells[3].Value.ToString();
            cbfornecedor.Text = TabelaProdutos.CurrentRow.Cells[4].Value.ToString();

            // alterar para guia de dados pessoais 
            tabProdutos.SelectedTab = tabPage1;
        }
    }
}
