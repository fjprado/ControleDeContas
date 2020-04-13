namespace InvestimentoDesktop
{
    partial class OperacaoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_quantidade = new System.Windows.Forms.NumericUpDown();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.cmb_tipo_operacao = new System.Windows.Forms.ComboBox();
            this.lbl_valor_total = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_ativo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(170, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo Operação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(23, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(206, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(29, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor Total";
            // 
            // txt_quantidade
            // 
            this.txt_quantidade.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.txt_quantidade.Location = new System.Drawing.Point(12, 160);
            this.txt_quantidade.Name = "txt_quantidade";
            this.txt_quantidade.Size = new System.Drawing.Size(121, 28);
            this.txt_quantidade.TabIndex = 4;
            this.txt_quantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_quantidade.ValueChanged += new System.EventHandler(this.txt_quantidade_ValueChanged);
            // 
            // txt_valor
            // 
            this.txt_valor.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.txt_valor.Location = new System.Drawing.Point(170, 159);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(121, 28);
            this.txt_valor.TabIndex = 5;
            this.txt_valor.Text = "0,00";
            this.txt_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_valor.TextChanged += new System.EventHandler(this.txt_valor_ValueChanged);
            // 
            // cmb_tipo_operacao
            // 
            this.cmb_tipo_operacao.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.cmb_tipo_operacao.FormattingEnabled = true;
            this.cmb_tipo_operacao.Location = new System.Drawing.Point(170, 93);
            this.cmb_tipo_operacao.Name = "cmb_tipo_operacao";
            this.cmb_tipo_operacao.Size = new System.Drawing.Size(121, 29);
            this.cmb_tipo_operacao.TabIndex = 7;
            // 
            // lbl_valor_total
            // 
            this.lbl_valor_total.AutoSize = true;
            this.lbl_valor_total.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_valor_total.Location = new System.Drawing.Point(206, 218);
            this.lbl_valor_total.Name = "lbl_valor_total";
            this.lbl_valor_total.Size = new System.Drawing.Size(41, 21);
            this.lbl_valor_total.TabIndex = 8;
            this.lbl_valor_total.Text = "0,00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(48, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ativo";
            // 
            // cmb_ativo
            // 
            this.cmb_ativo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.cmb_ativo.FormattingEnabled = true;
            this.cmb_ativo.Location = new System.Drawing.Point(12, 93);
            this.cmb_ativo.Name = "cmb_ativo";
            this.cmb_ativo.Size = new System.Drawing.Size(121, 29);
            this.cmb_ativo.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(96, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 23);
            this.label7.TabIndex = 11;
            this.label7.Text = "Operações";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(61, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Confirmar Operação";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OperacaoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 314);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_ativo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_valor_total);
            this.Controls.Add(this.cmb_tipo_operacao);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.txt_quantidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OperacaoForm";
            this.Text = "Operações";
            this.Load += new System.EventHandler(this.OperacaoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_quantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txt_quantidade;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.ComboBox cmb_tipo_operacao;
        private System.Windows.Forms.Label lbl_valor_total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_ativo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}