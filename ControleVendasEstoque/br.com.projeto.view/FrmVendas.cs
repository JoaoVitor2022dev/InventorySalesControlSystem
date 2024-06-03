using ControleVendasEstoque.br.com.projeto.dao;
using ControleVendasEstoque.br.com.projeto.model;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleVendasEstoque.br.com.projeto.view
{
    public partial class FrmVendas : Form
    {

        Cliente cliente = new Cliente();
        ClienteDAO cdao = new ClienteDAO();

        Produto produto = new Produto();
        ProdutoDAO pdao = new ProdutoDAO();

        public FrmVendas()
        {
            InitializeComponent();
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
    }
}
