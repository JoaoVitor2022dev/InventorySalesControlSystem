using ControleVendasEstoque.br.com.projeto.dao;
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
        }
    }
}
