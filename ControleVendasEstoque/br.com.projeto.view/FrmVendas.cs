using ControleVendasEstoque.br.com.projeto.dao;
using ControleVendasEstoque.br.com.projeto.model;
using System;
using System.Data;
using System.Drawing;
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            qtd = int.Parse(txtqtd.Text);
            preco = decimal.Parse(textpreco.Text); 

            subtotal = qtd * preco;

            total += subtotal;

            // adicionando produto no carrinho 
            carrinho.Rows.Add(int.Parse(txtcodigo.Text), txtdesc.Text, qtd, preco, subtotal);

            // adicionar o valor no total 
            txttotal.Text = total.ToString();

            // limpando os campos 
            txtcodigo.Clear();
            txtdesc.Clear();
            txtqtd.Clear();
            textpreco.Clear();

            txtcodigo.Focus(); 
        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            // botão remover item 

            decimal subproduto = decimal.Parse(TabelaProdutos.CurrentRow.Cells[4].Value.ToString());


            // selecionando a tabela 
            int index = TabelaProdutos.CurrentRow.Index;

            // aqui selecionando a limha
            DataRow linha = carrinho.Rows[index];

            carrinho.Rows.Remove(linha);

            carrinho.AcceptChanges();

            // subtração do total 

            total -= subtotal;

            txttotal.Text = total.ToString();

            MessageBox.Show("Item Removido do carrinho com sucesso!");
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            TabelaProdutos.DefaultCellStyle.ForeColor = Color.Black;
        }
    }
}
