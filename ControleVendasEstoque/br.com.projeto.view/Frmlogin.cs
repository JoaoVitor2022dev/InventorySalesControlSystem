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
    public partial class Frmlogin : Form
    {
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            // botoa entrar
            string email = txtemail.Text;
            string senha = Txtpassword.Text;

            FuncionarioDAO dao = new FuncionarioDAO();

            if (dao.EfetuarLogin(email,senha) == true)
            {
                FrmMenu TelaMenu = new FrmMenu();
                TelaMenu.Show();
                this.Hide(); 
            }
        }
    }
}
