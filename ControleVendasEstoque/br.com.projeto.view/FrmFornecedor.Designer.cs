namespace ControleVendasEstoque.br.com.projeto.view
{
    partial class FrmFornecedor
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
            this.tabFornecedor = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TabelaFuncionarios = new System.Windows.Forms.DataGridView();
            this.txtpesquisar = new System.Windows.Forms.Button();
            this.txtconsulta = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txteditar = new System.Windows.Forms.Button();
            this.btndeletar = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtrg = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcelular = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txttelefone = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcep = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txtuf = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.tabFornecedor.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaFuncionarios)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 157);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Fornecedores";
            // 
            // tabFornecedor
            // 
            this.tabFornecedor.Controls.Add(this.tabPage1);
            this.tabFornecedor.Controls.Add(this.tabPage2);
            this.tabFornecedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabFornecedor.Location = new System.Drawing.Point(8, 166);
            this.tabFornecedor.Name = "tabFornecedor";
            this.tabFornecedor.SelectedIndex = 0;
            this.tabFornecedor.Size = new System.Drawing.Size(971, 381);
            this.tabFornecedor.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TabelaFuncionarios);
            this.tabPage2.Controls.Add(this.txtpesquisar);
            this.tabPage2.Controls.Add(this.txtconsulta);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(963, 347);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TabelaFuncionarios
            // 
            this.TabelaFuncionarios.AllowUserToAddRows = false;
            this.TabelaFuncionarios.AllowUserToDeleteRows = false;
            this.TabelaFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaFuncionarios.Location = new System.Drawing.Point(8, 87);
            this.TabelaFuncionarios.Name = "TabelaFuncionarios";
            this.TabelaFuncionarios.ReadOnly = true;
            this.TabelaFuncionarios.Size = new System.Drawing.Size(943, 275);
            this.TabelaFuncionarios.TabIndex = 6;
            // 
            // txtpesquisar
            // 
            this.txtpesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtpesquisar.ForeColor = System.Drawing.Color.White;
            this.txtpesquisar.Location = new System.Drawing.Point(411, 11);
            this.txtpesquisar.Name = "txtpesquisar";
            this.txtpesquisar.Size = new System.Drawing.Size(130, 38);
            this.txtpesquisar.TabIndex = 5;
            this.txtpesquisar.Text = "Pesquisar";
            this.txtpesquisar.UseVisualStyleBackColor = false;
            // 
            // txtconsulta
            // 
            this.txtconsulta.BackColor = System.Drawing.SystemColors.Info;
            this.txtconsulta.Location = new System.Drawing.Point(101, 17);
            this.txtconsulta.Name = "txtconsulta";
            this.txtconsulta.Size = new System.Drawing.Size(291, 27);
            this.txtconsulta.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.ForestGreen;
            this.label18.Location = new System.Drawing.Point(23, 20);
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
            this.txteditar.Location = new System.Drawing.Point(714, 581);
            this.txteditar.Name = "txteditar";
            this.txteditar.Size = new System.Drawing.Size(130, 52);
            this.txteditar.TabIndex = 13;
            this.txteditar.Text = "Editar";
            this.txteditar.UseVisualStyleBackColor = false;
            // 
            // btndeletar
            // 
            this.btndeletar.BackColor = System.Drawing.Color.Red;
            this.btndeletar.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btndeletar.ForeColor = System.Drawing.Color.White;
            this.btndeletar.Location = new System.Drawing.Point(526, 581);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(130, 52);
            this.btndeletar.TabIndex = 12;
            this.btndeletar.Text = "Deletar";
            this.btndeletar.UseVisualStyleBackColor = false;
            // 
            // btnsalvar
            // 
            this.btnsalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnsalvar.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnsalvar.ForeColor = System.Drawing.Color.White;
            this.btnsalvar.Location = new System.Drawing.Point(333, 581);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(130, 52);
            this.btnsalvar.TabIndex = 11;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = false;
            // 
            // btnnovo
            // 
            this.btnnovo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnnovo.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnnovo.ForeColor = System.Drawing.Color.White;
            this.btnnovo.Location = new System.Drawing.Point(154, 581);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(130, 52);
            this.btnnovo.TabIndex = 10;
            this.btnnovo.Text = "Novo";
            this.btnnovo.UseVisualStyleBackColor = false;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.SystemColors.Info;
            this.txtcodigo.Location = new System.Drawing.Point(96, 22);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(68, 27);
            this.txtcodigo.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(18, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(18, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome:";
            // 
            // txtnome
            // 
            this.txtnome.BackColor = System.Drawing.SystemColors.Info;
            this.txtnome.Location = new System.Drawing.Point(96, 68);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(324, 27);
            this.txtnome.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(18, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "E-mail:";
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.SystemColors.Info;
            this.txtemail.Location = new System.Drawing.Point(96, 112);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(324, 27);
            this.txtemail.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.ForestGreen;
            this.label6.Location = new System.Drawing.Point(525, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "CPNJ:";
            // 
            // txtrg
            // 
            this.txtrg.BackColor = System.Drawing.SystemColors.Info;
            this.txtrg.Location = new System.Drawing.Point(590, 68);
            this.txtrg.Mask = "00,000,000/0000-00";
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(153, 27);
            this.txtrg.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.ForestGreen;
            this.label8.Location = new System.Drawing.Point(18, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "Celular:";
            // 
            // txtcelular
            // 
            this.txtcelular.BackColor = System.Drawing.SystemColors.Info;
            this.txtcelular.Location = new System.Drawing.Point(93, 193);
            this.txtcelular.Mask = "(00) 00000-0000";
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(192, 27);
            this.txtcelular.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.ForestGreen;
            this.label9.Location = new System.Drawing.Point(10, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 21);
            this.label9.TabIndex = 13;
            this.label9.Text = "Telefone:";
            // 
            // txttelefone
            // 
            this.txttelefone.BackColor = System.Drawing.SystemColors.Info;
            this.txttelefone.Location = new System.Drawing.Point(96, 150);
            this.txttelefone.Mask = "(00) 0000-0000";
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(189, 27);
            this.txttelefone.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.ForestGreen;
            this.label10.Location = new System.Drawing.Point(18, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 21);
            this.label10.TabIndex = 15;
            this.label10.Text = "CEP:";
            // 
            // txtcep
            // 
            this.txtcep.BackColor = System.Drawing.SystemColors.Info;
            this.txtcep.Location = new System.Drawing.Point(69, 288);
            this.txtcep.Mask = "00000-000";
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(110, 27);
            this.txtcep.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.ForestGreen;
            this.label11.Location = new System.Drawing.Point(10, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 21);
            this.label11.TabIndex = 17;
            this.label11.Text = "Endereço:";
            // 
            // txtendereco
            // 
            this.txtendereco.BackColor = System.Drawing.SystemColors.Info;
            this.txtendereco.Location = new System.Drawing.Point(109, 230);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(299, 27);
            this.txtendereco.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.ForestGreen;
            this.label12.Location = new System.Drawing.Point(505, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 21);
            this.label12.TabIndex = 19;
            this.label12.Text = "Número:";
            // 
            // txtnumero
            // 
            this.txtnumero.BackColor = System.Drawing.SystemColors.Info;
            this.txtnumero.Location = new System.Drawing.Point(590, 153);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(68, 27);
            this.txtnumero.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(299, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 21);
            this.label13.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.ForestGreen;
            this.label14.Location = new System.Drawing.Point(453, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 21);
            this.label14.TabIndex = 22;
            this.label14.Text = "Complemento:";
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.BackColor = System.Drawing.SystemColors.Info;
            this.txtcomplemento.Location = new System.Drawing.Point(590, 112);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(225, 27);
            this.txtcomplemento.TabIndex = 23;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.ForestGreen;
            this.label15.Location = new System.Drawing.Point(429, 245);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 21);
            this.label15.TabIndex = 24;
            this.label15.Text = "Bairro:";
            // 
            // txtbairro
            // 
            this.txtbairro.BackColor = System.Drawing.SystemColors.Info;
            this.txtbairro.Location = new System.Drawing.Point(492, 242);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(163, 27);
            this.txtbairro.TabIndex = 25;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.ForestGreen;
            this.label16.Location = new System.Drawing.Point(343, 294);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 21);
            this.label16.TabIndex = 26;
            this.label16.Text = "Cidade: ";
            // 
            // txtcidade
            // 
            this.txtcidade.BackColor = System.Drawing.SystemColors.Info;
            this.txtcidade.Location = new System.Drawing.Point(426, 290);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(155, 27);
            this.txtcidade.TabIndex = 27;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Location = new System.Drawing.Point(185, 284);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(130, 35);
            this.btnbuscar.TabIndex = 6;
            this.btnbuscar.Text = "Pesquisar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.ForestGreen;
            this.label20.Location = new System.Drawing.Point(625, 294);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(33, 21);
            this.label20.TabIndex = 35;
            this.label20.Text = "UF:";
            // 
            // txtuf
            // 
            this.txtuf.BackColor = System.Drawing.SystemColors.Info;
            this.txtuf.FormattingEnabled = true;
            this.txtuf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.txtuf.Location = new System.Drawing.Point(664, 291);
            this.txtuf.Name = "txtuf";
            this.txtuf.Size = new System.Drawing.Size(154, 29);
            this.txtuf.TabIndex = 36;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtuf);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.btnbuscar);
            this.tabPage1.Controls.Add(this.txtcidade);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.txtbairro);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.txtcomplemento);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtnumero);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtendereco);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.txtcep);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txttelefone);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtcelular);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtrg);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtemail);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtnome);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtcodigo);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(963, 347);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Pessoais";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // FrmFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 662);
            this.Controls.Add(this.txteditar);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.tabFornecedor);
            this.Controls.Add(this.panel1);
            this.Name = "FrmFornecedor";
            this.Text = "Cadastro de Fornecedores";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabFornecedor.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaFuncionarios)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabFornecedor;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView TabelaFuncionarios;
        private System.Windows.Forms.Button txtpesquisar;
        private System.Windows.Forms.TextBox txtconsulta;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button txteditar;
        private System.Windows.Forms.Button btndeletar;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox txtuf;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtcomplemento;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txtcep;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txttelefone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtcelular;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtrg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodigo;
    }
}