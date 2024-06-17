using ControleVendasEstoque.br.com.projeto.model;
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
    public partial class FrmPagamentos : Form
    {
        Cliente cliente = new Cliente();
        DataTable carrinho = new DataTable();

        public FrmPagamentos(DataTable carrinho, Cliente cliente)
        {
            this.cliente = cliente;
            this.carrinho = carrinho;
            InitializeComponent();
        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {

        }
    }
}
