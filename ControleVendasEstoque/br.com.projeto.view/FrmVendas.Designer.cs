namespace ControleVendasEstoque.br.com.projeto.view
{
    partial class FrmVendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textdata = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnremover = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtqtd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textpreco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.TabelaProdutos = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnpagamento = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaProdutos)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 157);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(285, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "TELA DE VENDAS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textdata);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtcpf);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(0, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 275);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // textdata
            // 
            this.textdata.BackColor = System.Drawing.SystemColors.Info;
            this.textdata.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textdata.Location = new System.Drawing.Point(159, 48);
            this.textdata.Name = "textdata";
            this.textdata.Size = new System.Drawing.Size(240, 27);
            this.textdata.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(86, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "Data:";
            // 
            // txtnome
            // 
            this.txtnome.BackColor = System.Drawing.SystemColors.Info;
            this.txtnome.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtnome.Location = new System.Drawing.Point(159, 162);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(240, 27);
            this.txtnome.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(86, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nome:";
            // 
            // txtcpf
            // 
            this.txtcpf.BackColor = System.Drawing.SystemColors.Info;
            this.txtcpf.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtcpf.Location = new System.Drawing.Point(159, 104);
            this.txtcpf.Mask = "000,000,000-00";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(240, 27);
            this.txtcpf.TabIndex = 12;
            this.txtcpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcpf_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(97, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "CPF:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtcodigo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnremover);
            this.groupBox2.Controls.Add(this.btnadd);
            this.groupBox2.Controls.Add(this.txtqtd);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textpreco);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtdesc);
            this.groupBox2.Location = new System.Drawing.Point(0, 447);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 450);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(62, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Descrição:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.BackColor = System.Drawing.SystemColors.Info;
            this.txtcodigo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtcodigo.Location = new System.Drawing.Point(159, 68);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(165, 27);
            this.txtcodigo.TabIndex = 18;
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(79, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Código:";
            // 
            // btnremover
            // 
            this.btnremover.BackColor = System.Drawing.Color.Red;
            this.btnremover.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnremover.ForeColor = System.Drawing.Color.White;
            this.btnremover.Location = new System.Drawing.Point(270, 351);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(178, 42);
            this.btnremover.TabIndex = 16;
            this.btnremover.Text = "Remover Item";
            this.btnremover.UseVisualStyleBackColor = false;
            this.btnremover.Click += new System.EventHandler(this.btnremover_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnadd.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(43, 351);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(178, 42);
            this.btnadd.TabIndex = 15;
            this.btnadd.Text = "Adicionar Item";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtqtd
            // 
            this.txtqtd.BackColor = System.Drawing.SystemColors.Info;
            this.txtqtd.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtqtd.Location = new System.Drawing.Point(159, 254);
            this.txtqtd.Name = "txtqtd";
            this.txtqtd.Size = new System.Drawing.Size(165, 27);
            this.txtqtd.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(38, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Qtd Estoque:";
            // 
            // textpreco
            // 
            this.textpreco.BackColor = System.Drawing.SystemColors.Info;
            this.textpreco.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textpreco.Location = new System.Drawing.Point(159, 201);
            this.textpreco.Name = "textpreco";
            this.textpreco.Size = new System.Drawing.Size(165, 27);
            this.textpreco.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(58, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Preço (R$):";
            // 
            // txtdesc
            // 
            this.txtdesc.BackColor = System.Drawing.SystemColors.Info;
            this.txtdesc.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtdesc.Location = new System.Drawing.Point(159, 138);
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(165, 27);
            this.txtdesc.TabIndex = 8;
            // 
            // TabelaProdutos
            // 
            this.TabelaProdutos.AllowUserToAddRows = false;
            this.TabelaProdutos.AllowUserToDeleteRows = false;
            this.TabelaProdutos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.TabelaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaProdutos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TabelaProdutos.Location = new System.Drawing.Point(474, 174);
            this.TabelaProdutos.Name = "TabelaProdutos";
            this.TabelaProdutos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TabelaProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TabelaProdutos.Size = new System.Drawing.Size(534, 511);
            this.TabelaProdutos.TabIndex = 7;
            this.TabelaProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txttotal);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(474, 701);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(534, 86);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.SystemColors.Info;
            this.txttotal.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txttotal.Location = new System.Drawing.Point(193, 21);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(240, 27);
            this.txttotal.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(108, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Total (R$):";
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Red;
            this.btncancelar.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(725, 830);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(234, 67);
            this.btncancelar.TabIndex = 21;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            // 
            // btnpagamento
            // 
            this.btnpagamento.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnpagamento.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnpagamento.ForeColor = System.Drawing.Color.White;
            this.btnpagamento.Location = new System.Drawing.Point(474, 830);
            this.btnpagamento.Name = "btnpagamento";
            this.btnpagamento.Size = new System.Drawing.Size(212, 67);
            this.btnpagamento.TabIndex = 20;
            this.btnpagamento.Text = "Pagamento";
            this.btnpagamento.UseVisualStyleBackColor = false;
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 936);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnpagamento);
            this.Controls.Add(this.TabelaProdutos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FrmVendas";
            this.Text = "Tela de Venads";
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaProdutos)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.TextBox textpreco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtqtd;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView TabelaProdutos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnpagamento;
        private System.Windows.Forms.TextBox textdata;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txttotal;
    }
}