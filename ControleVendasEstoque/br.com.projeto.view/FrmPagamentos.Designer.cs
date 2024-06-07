namespace ControleVendasEstoque.br.com.projeto.view
{
    partial class FrmPagamentos
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
            this.txtdinheiro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcartao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttroco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnfinalizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(675, 157);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(179, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pagamento";
            // 
            // txtdinheiro
            // 
            this.txtdinheiro.BackColor = System.Drawing.SystemColors.Info;
            this.txtdinheiro.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdinheiro.Location = new System.Drawing.Point(299, 195);
            this.txtdinheiro.Name = "txtdinheiro";
            this.txtdinheiro.Size = new System.Drawing.Size(307, 50);
            this.txtdinheiro.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(43, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 42);
            this.label2.TabIndex = 19;
            this.label2.Text = "Dinheiro (R$): ";
            // 
            // txtcartao
            // 
            this.txtcartao.BackColor = System.Drawing.SystemColors.Info;
            this.txtcartao.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcartao.Location = new System.Drawing.Point(299, 265);
            this.txtcartao.Name = "txtcartao";
            this.txtcartao.Size = new System.Drawing.Size(307, 50);
            this.txtcartao.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(134, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 42);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cartão: ";
            // 
            // txttroco
            // 
            this.txttroco.BackColor = System.Drawing.SystemColors.Info;
            this.txttroco.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttroco.Location = new System.Drawing.Point(299, 335);
            this.txttroco.Name = "txttroco";
            this.txttroco.ReadOnly = true;
            this.txttroco.Size = new System.Drawing.Size(307, 50);
            this.txttroco.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(161, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 42);
            this.label4.TabIndex = 23;
            this.label4.Text = "Troco: ";
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.SystemColors.Info;
            this.txttotal.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(299, 409);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(307, 50);
            this.txttotal.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(171, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 42);
            this.label5.TabIndex = 25;
            this.label5.Text = "Total:";
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnfinalizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfinalizar.ForeColor = System.Drawing.Color.White;
            this.btnfinalizar.Location = new System.Drawing.Point(161, 478);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.Size = new System.Drawing.Size(332, 67);
            this.btnfinalizar.TabIndex = 27;
            this.btnfinalizar.Text = "Finalizar Venda";
            this.btnfinalizar.UseVisualStyleBackColor = false;
            // 
            // FrmPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 571);
            this.Controls.Add(this.btnfinalizar);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttroco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcartao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdinheiro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPagamentos";
            this.Text = "Tela Pagamentos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdinheiro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcartao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttroco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnfinalizar;
        public System.Windows.Forms.TextBox txttotal;
    }
}