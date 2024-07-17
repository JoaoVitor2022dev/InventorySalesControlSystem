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
    public partial class FrmDetalhes : Form
    {
        int id_venda; 
        public FrmDetalhes(int id_venda)
        {
            this.id_venda = id_venda;
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmDetalhes_Load(object sender, EventArgs e)
        {
            // Carrega tela de detalhes 
            ItemVendasDAO dao = new ItemVendasDAO();

            tabelaDetalhes.DataSource = dao.ListarItensPorVenda(id_venda); 
        }
    }
}
