using ControleVendasEstoque.br.com.projeto.dao;
using ControleVendasEstoque.br.com.projeto.model;
using System;
using System.Data;
using System.Windows.Forms;

namespace ControleVendasEstoque.br.com.projeto.view
{
    public partial class FrmVendas : Form
    {

        Cliente cliente = new Cliente();
        ClienteDAO cdao = new ClienteDAO();

        Produto produto = new Produto();
        ProdutoDAO pdao = new ProdutoDAO();

        // variaveis 
        int qtd;
        decimal preco;
        decimal subtotal, total; 

        // Carrinho 
        DataTable carrinho = new DataTable();   


        public FrmVendas()
        {
            InitializeComponent();

            carrinho.Columns.Add("Codigo", typeof(string));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Qtd", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("Subtotal", typeof(decimal));

            TabelaProdutos.DataSource = carrinho;
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtcpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cliente = cdao.RetornaClientePorCpf(txtcpf.Text);

                txtnome.Text = cliente.name; 
            }
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                produto = pdao.RetornaProdutoPerCodigo(int.Parse(txtcodigo.Text));

                txtdesc.Text = produto.Descricao;
                textpreco.Text = produto.Preco.ToString();
            }
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {

        }
    }
}
