namespace ControleVendasEstoque.br.com.projeto.view
{
    partial class FrmProduto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabProdutos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.cbfornecedor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textpreco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtqtd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TabelaProdutos = new System.Windows.Forms.DataGridView();
            this.txtpesquisar = new System.Windows.Forms.Button();
            this.txtconsulta = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txteditar = new System.Windows.Forms.Button();
            this.btndeletar = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabProdutos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 157);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Produtos";
            // 
            // tabProdutos
            // 
            this.tabProdutos.Controls.Add(this.tabPage1);
            this.tabProdutos.Controls.Add(this.tabPage2);
            this.tabProdutos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProdutos.Location = new System.Drawing.Point(0, 155);
            this.tabProdutos.Name = "tabProdutos";
            this.tabProdutos.SelectedIndex = 0;
            this.tabProdutos.Size = new System.Drawing.Size(984, 385);
            this.tabProdutos.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cbfornecedor);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textpreco);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtqtd);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtdesc);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtcodigo);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Pessoais";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(536, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 21);
            this.label7.TabIndex = 11;
            // 
            // cbfornecedor
            // 
            this.cbfornecedor.BackColor = System.Drawing.SystemColors.Info;
            this.cbfornecedor.FormattingEnabled = true;
            this.cbfornecedor.Location = new System.Drawing.Point(138, 156);
            this.cbfornecedor.Name = "cbfornecedor";
            this.cbfornecedor.Size = new System.Drawing.Size(308, 29);
            this.cbfornecedor.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(28, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fornecedor:";
            // 
            // textpreco
            // 
            this.textpreco.BackColor = System.Drawing.SystemColors.Info;
            this.textpreco.Location = new System.Drawing.Point(581, 71);
            this.textpreco.Name = "textpreco";
            this.textpreco.Size = new System.Drawing.Size(100, 27);
            this.textpreco.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(482, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Preço (R$):";
            // 
            // txtqtd
            // 
            this.txtqtd.BackColor = System.Drawing.SystemColors.Info;
            this.txtqtd.Location = new System.Drawing.Point(137, 112);
            this.txtqtd.Name = "txtqtd";
            this.txtqtd.Size = new System.Drawing.Size(324, 27);
            this.txtqtd.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(18, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Qtd Estoque:";
            // 
            // txtdesc
            // 
            this.txtdesc.BackColor = System.Drawing.SystemColors.Info;
            this.txtdesc.Location = new System.Drawing.Point(137, 68);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(324, 27);
            this.txtdesc.TabIndex = 4;
            this.txtdesc.TextChanged += new System.EventHandler(this.txtdesc_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(40, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descrição:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(59, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.SystemColors.Info;
            this.txtcodigo.Location = new System.Drawing.Point(137, 22);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(68, 27);
            this.txtcodigo.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.TabelaProdutos);
            this.tabPage2.Controls.Add(this.txtpesquisar);
            this.tabPage2.Controls.Add(this.txtconsulta);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            // 
            // TabelaProdutos
            // 
            this.TabelaProdutos.AllowUserToAddRows = false;
            this.TabelaProdutos.AllowUserToDeleteRows = false;
            this.TabelaProdutos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.TabelaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaProdutos.Location = new System.Drawing.Point(195, 70);
            this.TabelaProdutos.Name = "TabelaProdutos";
            this.TabelaProdutos.ReadOnly = true;
            this.TabelaProdutos.Size = new System.Drawing.Size(538, 275);
            this.TabelaProdutos.TabIndex = 6;
            this.TabelaProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaProdutos_CellClick);
            // 
            // txtpesquisar
            // 
            this.txtpesquisar.BackColor = System.Drawing.Color.DarkCyan;
            this.txtpesquisar.ForeColor = System.Drawing.Color.White;
            this.txtpesquisar.Location = new System.Drawing.Point(603, 12);
            this.txtpesquisar.Name = "txtpesquisar";
            this.txtpesquisar.Size = new System.Drawing.Size(130, 38);
            this.txtpesquisar.TabIndex = 5;
            this.txtpesquisar.Text = "Pesquisar";
            this.txtpesquisar.UseVisualStyleBackColor = false;
            this.txtpesquisar.Click += new System.EventHandler(this.txtpesquisar_Click);
            // 
            // txtconsulta
            // 
            this.txtconsulta.BackColor = System.Drawing.SystemColors.Info;
            this.txtconsulta.Location = new System.Drawing.Point(231, 18);
            this.txtconsulta.Name = "txtconsulta";
            this.txtconsulta.Size = new System.Drawing.Size(291, 27);
            this.txtconsulta.TabIndex = 4;
            this.txtconsulta.TextChanged += new System.EventHandler(this.txtconsulta_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.DarkBlue;
            this.label18.Location = new System.Drawing.Point(164, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 21);
            this.label18.TabIndex = 3;
            this.label18.Text = "Nome:";
            // 
            // txteditar
            // 
            this.txteditar.BackColor = System.Drawing.Color.Gold;
            this.txteditar.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.txteditar.ForeColor = System.Drawing.Color.Black;
            this.txteditar.Location = new System.Drawing.Point(701, 570);
            this.txteditar.Name = "txteditar";
            this.txteditar.Size = new System.Drawing.Size(130, 52);
            this.txteditar.TabIndex = 17;
            this.txteditar.Text = "Editar";
            this.txteditar.UseVisualStyleBackColor = false;
            this.txteditar.Click += new System.EventHandler(this.txteditar_Click);
            // 
            // btndeletar
            // 
            this.btndeletar.BackColor = System.Drawing.Color.Red;
            this.btndeletar.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btndeletar.ForeColor = System.Drawing.Color.White;
            this.btndeletar.Location = new System.Drawing.Point(513, 570);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(130, 52);
            this.btndeletar.TabIndex = 16;
            this.btndeletar.Text = "Deletar";
            this.btndeletar.UseVisualStyleBackColor = false;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnsalvar.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnsalvar.ForeColor = System.Drawing.Color.White;
            this.btnsalvar.Location = new System.Drawing.Point(320, 570);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(130, 52);
            this.btnsalvar.TabIndex = 15;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = false;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnnovo.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnnovo.ForeColor = System.Drawing.Color.White;
            this.btnnovo.Location = new System.Drawing.Point(141, 570);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(130, 52);
            this.btnnovo.TabIndex = 14;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = false;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(984, 654);
            this.Controls.Add(this.txteditar);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.tabProdutos);
            this.Controls.Add(this.panel1);
            this.Name = "FrmProduto";
            this.Text = "Cadastro de Produtos";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabProdutos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabProdutos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtqtd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView TabelaProdutos;
        private System.Windows.Forms.Button txtpesquisar;
        private System.Windows.Forms.TextBox txtconsulta;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button txteditar;
        private System.Windows.Forms.Button btndeletar;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.TextBox textpreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbfornecedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}