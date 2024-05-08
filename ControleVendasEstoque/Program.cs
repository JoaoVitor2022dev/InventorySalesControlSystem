using ControleVendasEstoque.br.com.projeto.view;
using System;
using System.Windows.Forms;

namespace ControleVendasEstoque
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frmclientes());
        }
    }
}
