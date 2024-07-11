using ControleVendasEstoque.br.com.projeto.dao;
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
    public partial class FrmHistorico : Form
    {
        public FrmHistorico()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnpesquisaHistorico_Click(object sender, EventArgs e)
        {
            DateTime datainicial, datafim;

            datainicial = Convert.ToDateTime(dtInicio.Value.ToString("yyyy-MM-dd"));
            datafim = Convert.ToDateTime(dtFim.Value.ToString("yyyy-MM-dd")); 

            VendasDAO dao = new VendasDAO();

            tabeelaHistorico.DataSource = dao.ListarVendasPoPeriodos(datainicial, datafim);
        }

        private void FrmHistorico_Load(object sender, EventArgs e)
        {
            VendasDAO dao = new VendasDAO();

            tabeelaHistorico.DataSource = dao.ListarVendas();
            tabeelaHistorico.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void tabeelaHistorico_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1 - primeiro passo - abrir outro formulario
            FrmDetalhes Tela = new FrmDetalhes();

            DateTime DataVenda = Convert.ToDateTime(tabeelaHistorico.CurrentRow.Cells[1].Value.ToString());

            Tela.txtData.Text = DataVenda.ToString("dd/MM/yyyy");
            Tela.txtcliente.Text = tabeelaHistorico.CurrentRow.Cells[2].Value.ToString();
            Tela.txttotal.Text = tabeelaHistorico.CurrentRow.Cells[3].Value.ToString();
            Tela.txtObs.Text = tabeelaHistorico.CurrentRow.Cells[4].Value.ToString();

            Tela.ShowDialog(); 
        }
    }
}
