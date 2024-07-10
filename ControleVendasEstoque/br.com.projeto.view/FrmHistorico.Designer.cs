namespace ControleVendasEstoque.br.com.projeto.view
{
    partial class FrmHistorico
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnpesquisaHistorico = new System.Windows.Forms.Button();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabeelaHistorico = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabeelaHistorico)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(912, 157);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(189, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Histórico de Vendas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnpesquisaHistorico);
            this.groupBox1.Controls.Add(this.dtFim);
            this.groupBox1.Controls.Add(this.dtInicio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(14, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 175);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta";
            // 
            // btnpesquisaHistorico
            // 
            this.btnpesquisaHistorico.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnpesquisaHistorico.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnpesquisaHistorico.ForeColor = System.Drawing.Color.White;
            this.btnpesquisaHistorico.Location = new System.Drawing.Point(734, 62);
            this.btnpesquisaHistorico.Name = "btnpesquisaHistorico";
            this.btnpesquisaHistorico.Size = new System.Drawing.Size(123, 43);
            this.btnpesquisaHistorico.TabIndex = 10;
            this.btnpesquisaHistorico.Text = "Pesquisar";
            this.btnpesquisaHistorico.UseVisualStyleBackColor = false;
            this.btnpesquisaHistorico.Click += new System.EventHandler(this.btnpesquisaHistorico_Click);
            // 
            // dtFim
            // 
            this.dtFim.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFim.Location = new System.Drawing.Point(484, 68);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(200, 27);
            this.dtFim.TabIndex = 9;
            // 
            // dtInicio
            // 
            this.dtInicio.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(165, 68);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(200, 27);
            this.dtInicio.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(393, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data Fim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(63, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data Inicio:";
            // 
            // tabeelaHistorico
            // 
            this.tabeelaHistorico.AllowUserToAddRows = false;
            this.tabeelaHistorico.AllowUserToDeleteRows = false;
            this.tabeelaHistorico.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabeelaHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabeelaHistorico.Location = new System.Drawing.Point(14, 349);
            this.tabeelaHistorico.Name = "tabeelaHistorico";
            this.tabeelaHistorico.ReadOnly = true;
            this.tabeelaHistorico.Size = new System.Drawing.Size(883, 320);
            this.tabeelaHistorico.TabIndex = 8;
            this.tabeelaHistorico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FrmHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 681);
            this.Controls.Add(this.tabeelaHistorico);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmHistorico";
            this.Text = "Histórico de Vendas ";
            this.Load += new System.EventHandler(this.FrmHistorico_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabeelaHistorico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.Button btnpesquisaHistorico;
        private System.Windows.Forms.DataGridView tabeelaHistorico;
    }
}