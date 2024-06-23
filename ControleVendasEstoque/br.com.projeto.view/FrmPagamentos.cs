using ControleVendasEstoque.br.com.projeto.dao;
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
        DateTime dataAtual;

        public FrmPagamentos(DataTable carrinho, Cliente cliente, DateTime dataAtual)
        {
            this.cliente = cliente;
            this.carrinho = carrinho;
            this.dataAtual = dataAtual;
            InitializeComponent();
        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                // finalizar venda 
                decimal v_dinheiro, v_cartao, troco, totalpago, total;

                v_dinheiro = decimal.Parse(txtdinheiro.Text);
                v_cartao = decimal.Parse(txtcartao.Text); 
                total = decimal.Parse(txttotal.Text);

                // calcular o troco da venda 

                totalpago = v_dinheiro + v_cartao;

                if (totalpago <= total)
                {
                    MessageBox.Show("Total pago é menor que o valor total da venda.");
                }
                else
                {
                    troco = totalpago - total;

                    Vendas vendas = new Vendas();

                    vendas.cliente_id = cliente.codigo;
                    vendas.Data_vendas = dataAtual;
                    vendas.Total_vendas = total;
                    vendas.obs = textobs.Text; 

                    VendasDAO vdao = new VendasDAO();

                    txttroco.Text = troco.ToString();
                    vdao.RegistrarVenda(vendas);


                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ocorreu um erro na sua venda");
            }


        }

        private void FrmPagamentos_Load(object sender, EventArgs e)
        {
            txttroco.Text = "0.00";
            txtdinheiro.Text = "0.00";
            txtcartao.Text = "0.00"; 


        }
    }
}
