namespace ControleVendasEstoque.br.com.projeto.view
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menucliente = new System.Windows.Forms.ToolStripMenuItem();
            this.txtmenuclientecadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.txtmenuclienteconsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.Clientfuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.txtmenuFuncionarioCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.txtmenufuncionarioconsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.txtmenuFornecedorCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.txtmenuFornecedorConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.txtmenuProdutoCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.txtmenuProdutoConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.txtmenuNovaVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.txtmenuHistoricoVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.configuração = new System.Windows.Forms.ToolStripMenuItem();
            this.txtmenuTrocaUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.txtmenuSairSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtdata = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txthora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtusuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menucliente,
            this.Clientfuncionario,
            this.MenuFornecedor,
            this.MenuProdutos,
            this.MenuVendas,
            this.configuração});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(999, 56);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menucliente
            // 
            this.Menucliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtmenuclientecadastrar,
            this.txtmenuclienteconsulta});
            this.Menucliente.Image = global::ControleVendasEstoque.Properties.Resources._4308184_client_costs_employee_finance_money_icon;
            this.Menucliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Menucliente.Name = "Menucliente";
            this.Menucliente.Size = new System.Drawing.Size(109, 52);
            this.Menucliente.Text = "Clientes";
            // 
            // txtmenuclientecadastrar
            // 
            this.txtmenuclientecadastrar.Name = "txtmenuclientecadastrar";
            this.txtmenuclientecadastrar.Size = new System.Drawing.Size(180, 22);
            this.txtmenuclientecadastrar.Text = "Cadastrar Cliente";
            this.txtmenuclientecadastrar.Click += new System.EventHandler(this.txtmenuclientecadastrar_Click);
            // 
            // txtmenuclienteconsulta
            // 
            this.txtmenuclienteconsulta.Name = "txtmenuclienteconsulta";
            this.txtmenuclienteconsulta.Size = new System.Drawing.Size(180, 22);
            this.txtmenuclienteconsulta.Text = "Consultar Cliente";
            this.txtmenuclienteconsulta.Click += new System.EventHandler(this.txtmenuclienteconsulta_Click);
            // 
            // Clientfuncionario
            // 
            this.Clientfuncionario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtmenuFuncionarioCadastrar,
            this.txtmenufuncionarioconsulta});
            this.Clientfuncionario.Image = global::ControleVendasEstoque.Properties.Resources._2530821_business_man_employee_general_human_member_icon;
            this.Clientfuncionario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Clientfuncionario.Name = "Clientfuncionario";
            this.Clientfuncionario.Size = new System.Drawing.Size(130, 52);
            this.Clientfuncionario.Text = "Funcionário";
            // 
            // txtmenuFuncionarioCadastrar
            // 
            this.txtmenuFuncionarioCadastrar.Name = "txtmenuFuncionarioCadastrar";
            this.txtmenuFuncionarioCadastrar.Size = new System.Drawing.Size(191, 22);
            this.txtmenuFuncionarioCadastrar.Text = "Cadastrar Funcionário";
            this.txtmenuFuncionarioCadastrar.Click += new System.EventHandler(this.txtmenuFuncionarioCadastrar_Click);
            // 
            // txtmenufuncionarioconsulta
            // 
            this.txtmenufuncionarioconsulta.Name = "txtmenufuncionarioconsulta";
            this.txtmenufuncionarioconsulta.Size = new System.Drawing.Size(191, 22);
            this.txtmenufuncionarioconsulta.Text = "Consultar Funcionário";
            this.txtmenufuncionarioconsulta.Click += new System.EventHandler(this.txtmenufuncionarioconsulta_Click);
            // 
            // MenuFornecedor
            // 
            this.MenuFornecedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtmenuFornecedorCadastrar,
            this.txtmenuFornecedorConsulta});
            this.MenuFornecedor.Image = global::ControleVendasEstoque.Properties.Resources._4172394_goods_merchandise_stock_supply_vendibles_icon;
            this.MenuFornecedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuFornecedor.Name = "MenuFornecedor";
            this.MenuFornecedor.Size = new System.Drawing.Size(138, 52);
            this.MenuFornecedor.Text = "Fornecedores";
            // 
            // txtmenuFornecedorCadastrar
            // 
            this.txtmenuFornecedorCadastrar.Name = "txtmenuFornecedorCadastrar";
            this.txtmenuFornecedorCadastrar.Size = new System.Drawing.Size(188, 22);
            this.txtmenuFornecedorCadastrar.Text = "Cadastrar Fornecedor";
            this.txtmenuFornecedorCadastrar.Click += new System.EventHandler(this.txtmenuFornecedorCadastrar_Click);
            // 
            // txtmenuFornecedorConsulta
            // 
            this.txtmenuFornecedorConsulta.Name = "txtmenuFornecedorConsulta";
            this.txtmenuFornecedorConsulta.Size = new System.Drawing.Size(188, 22);
            this.txtmenuFornecedorConsulta.Text = "Consultar Fornecedor";
            this.txtmenuFornecedorConsulta.Click += new System.EventHandler(this.txtmenuFornecedorConsulta_Click);
            // 
            // MenuProdutos
            // 
            this.MenuProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtmenuProdutoCadastrar,
            this.txtmenuProdutoConsultar});
            this.MenuProdutos.Image = global::ControleVendasEstoque.Properties.Resources._6843036_courier_deliver_delivery_package_product_icon;
            this.MenuProdutos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuProdutos.Name = "MenuProdutos";
            this.MenuProdutos.Size = new System.Drawing.Size(115, 52);
            this.MenuProdutos.Text = "Produtos";
            // 
            // txtmenuProdutoCadastrar
            // 
            this.txtmenuProdutoCadastrar.Name = "txtmenuProdutoCadastrar";
            this.txtmenuProdutoCadastrar.Size = new System.Drawing.Size(180, 22);
            this.txtmenuProdutoCadastrar.Text = "Cadastrar Produtos";
            this.txtmenuProdutoCadastrar.Click += new System.EventHandler(this.txtmenuProdutoCadastrar_Click);
            // 
            // txtmenuProdutoConsultar
            // 
            this.txtmenuProdutoConsultar.Name = "txtmenuProdutoConsultar";
            this.txtmenuProdutoConsultar.Size = new System.Drawing.Size(180, 22);
            this.txtmenuProdutoConsultar.Text = "Consultar Produtos";
            this.txtmenuProdutoConsultar.Click += new System.EventHandler(this.txtmenuProdutoConsultar_Click);
            // 
            // MenuVendas
            // 
            this.MenuVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtmenuNovaVenda,
            this.txtmenuHistoricoVenda});
            this.MenuVendas.Image = global::ControleVendasEstoque.Properties.Resources._465074_cart_purchase_shopping_basket_buy_icon;
            this.MenuVendas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MenuVendas.Name = "MenuVendas";
            this.MenuVendas.Size = new System.Drawing.Size(104, 52);
            this.MenuVendas.Text = "Vendas";
            // 
            // txtmenuNovaVenda
            // 
            this.txtmenuNovaVenda.Name = "txtmenuNovaVenda";
            this.txtmenuNovaVenda.Size = new System.Drawing.Size(180, 22);
            this.txtmenuNovaVenda.Text = "Nova Vendas";
            this.txtmenuNovaVenda.Click += new System.EventHandler(this.txtmenuNovaVenda_Click);
            // 
            // txtmenuHistoricoVenda
            // 
            this.txtmenuHistoricoVenda.Name = "txtmenuHistoricoVenda";
            this.txtmenuHistoricoVenda.Size = new System.Drawing.Size(180, 22);
            this.txtmenuHistoricoVenda.Text = "Histórico Vendas";
            this.txtmenuHistoricoVenda.Click += new System.EventHandler(this.txtmenuHistoricoVenda_Click);
            // 
            // configuração
            // 
            this.configuração.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtmenuTrocaUsuario,
            this.txtmenuSairSistema});
            this.configuração.Image = global::ControleVendasEstoque.Properties.Resources._211670_b_gear_icon;
            this.configuração.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.configuração.Name = "configuração";
            this.configuração.Size = new System.Drawing.Size(144, 52);
            this.configuração.Text = "Configurações";
            // 
            // txtmenuTrocaUsuario
            // 
            this.txtmenuTrocaUsuario.Name = "txtmenuTrocaUsuario";
            this.txtmenuTrocaUsuario.Size = new System.Drawing.Size(165, 22);
            this.txtmenuTrocaUsuario.Text = "Trocar de Usuário";
            // 
            // txtmenuSairSistema
            // 
            this.txtmenuSairSistema.Name = "txtmenuSairSistema";
            this.txtmenuSairSistema.Size = new System.Drawing.Size(165, 22);
            this.txtmenuSairSistema.Text = "Sair do Sistema";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtdata,
            this.toolStripStatusLabel3,
            this.txthora,
            this.toolStripStatusLabel5,
            this.txtusuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 607);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(999, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel1.Text = "Data Atual:";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // txtdata
            // 
            this.txtdata.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(73, 17);
            this.txtdata.Text = "21/07/2024";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabel3.Text = "Hora Atual:";
            // 
            // txthora
            // 
            this.txthora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(38, 17);
            this.txthora.Text = "10:30";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(93, 17);
            this.toolStripStatusLabel5.Text = "Usuário Logado:";
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(63, 17);
            this.txtusuario.Text = "João Vitor";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControleVendasEstoque.Properties.Resources.logo_menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(999, 629);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Menu Principal - Controle de Vendas";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menucliente;
        private System.Windows.Forms.ToolStripMenuItem txtmenuclientecadastrar;
        private System.Windows.Forms.ToolStripMenuItem txtmenuclienteconsulta;
        private System.Windows.Forms.ToolStripMenuItem Clientfuncionario;
        private System.Windows.Forms.ToolStripMenuItem MenuFornecedor;
        private System.Windows.Forms.ToolStripMenuItem txtmenuFuncionarioCadastrar;
        private System.Windows.Forms.ToolStripMenuItem txtmenufuncionarioconsulta;
        private System.Windows.Forms.ToolStripMenuItem MenuVendas;
        private System.Windows.Forms.ToolStripMenuItem configuração;
        private System.Windows.Forms.ToolStripMenuItem txtmenuFornecedorCadastrar;
        private System.Windows.Forms.ToolStripMenuItem txtmenuFornecedorConsulta;
        private System.Windows.Forms.ToolStripMenuItem txtmenuProdutoCadastrar;
        private System.Windows.Forms.ToolStripMenuItem txtmenuProdutoConsultar;
        private System.Windows.Forms.ToolStripMenuItem txtmenuNovaVenda;
        private System.Windows.Forms.ToolStripMenuItem txtmenuHistoricoVenda;
        private System.Windows.Forms.ToolStripMenuItem txtmenuTrocaUsuario;
        private System.Windows.Forms.ToolStripMenuItem txtmenuSairSistema;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtdata;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel txthora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        public System.Windows.Forms.ToolStripMenuItem MenuProdutos;
        public System.Windows.Forms.ToolStripStatusLabel txtusuario;
        private System.Windows.Forms.Timer timer1;
    }
}