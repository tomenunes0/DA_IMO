namespace Projeto_DA
{
    partial class GerirLimpezas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GerirLimpezas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblInformacaoCasa = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_ListaDeLimpezas = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_ListaDeServicos = new System.Windows.Forms.ListBox();
            this.btnNovoServico = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nudUnidades = new System.Windows.Forms.NumericUpDown();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.cb_Descricao = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEmiteFatura = new System.Windows.Forms.Button();
            this.btnNovaLimpeza = new System.Windows.Forms.Button();
            this.dtpDataDaLimpeza = new System.Windows.Forms.DateTimePicker();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnRemoverServicos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnidades)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblInformacaoCasa);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informação da Casa";
            // 
            // lblInformacaoCasa
            // 
            this.lblInformacaoCasa.AutoSize = true;
            this.lblInformacaoCasa.Location = new System.Drawing.Point(16, 39);
            this.lblInformacaoCasa.Name = "lblInformacaoCasa";
            this.lblInformacaoCasa.Size = new System.Drawing.Size(309, 24);
            this.lblInformacaoCasa.TabIndex = 0;
            this.lblInformacaoCasa.Text = "Vendavel: 2  - Batalha Batalha";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnRemover);
            this.groupBox2.Controls.Add(this.lb_ListaDeLimpezas);
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 423);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Limpezas";
            // 
            // lb_ListaDeLimpezas
            // 
            this.lb_ListaDeLimpezas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_ListaDeLimpezas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_ListaDeLimpezas.FormattingEnabled = true;
            this.lb_ListaDeLimpezas.ItemHeight = 24;
            this.lb_ListaDeLimpezas.Location = new System.Drawing.Point(6, 27);
            this.lb_ListaDeLimpezas.Name = "lb_ListaDeLimpezas";
            this.lb_ListaDeLimpezas.Size = new System.Drawing.Size(399, 340);
            this.lb_ListaDeLimpezas.TabIndex = 0;
            this.lb_ListaDeLimpezas.SelectedIndexChanged += new System.EventHandler(this.lb_ListaDeLimpezas_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btnRemoverServicos);
            this.groupBox3.Controls.Add(this.lb_ListaDeServicos);
            this.groupBox3.Controls.Add(this.btnNovoServico);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.nudUnidades);
            this.groupBox3.Controls.Add(this.lblValorUnitario);
            this.groupBox3.Controls.Add(this.cb_Descricao);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(429, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(712, 516);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de Limpezas";
            // 
            // lb_ListaDeServicos
            // 
            this.lb_ListaDeServicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_ListaDeServicos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_ListaDeServicos.FormattingEnabled = true;
            this.lb_ListaDeServicos.ItemHeight = 24;
            this.lb_ListaDeServicos.Location = new System.Drawing.Point(6, 120);
            this.lb_ListaDeServicos.Name = "lb_ListaDeServicos";
            this.lb_ListaDeServicos.Size = new System.Drawing.Size(699, 340);
            this.lb_ListaDeServicos.TabIndex = 1;
            this.lb_ListaDeServicos.SelectedIndexChanged += new System.EventHandler(this.lb_ListaDeServicos_SelectedIndexChanged);
            // 
            // btnNovoServico
            // 
            this.btnNovoServico.BackColor = System.Drawing.Color.DarkGreen;
            this.btnNovoServico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoServico.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNovoServico.FlatAppearance.BorderSize = 5;
            this.btnNovoServico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnNovoServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnNovoServico.ForeColor = System.Drawing.Color.White;
            this.btnNovoServico.Location = new System.Drawing.Point(551, 29);
            this.btnNovoServico.Name = "btnNovoServico";
            this.btnNovoServico.Size = new System.Drawing.Size(154, 46);
            this.btnNovoServico.TabIndex = 27;
            this.btnNovoServico.Text = "Novo ➕";
            this.btnNovoServico.UseVisualStyleBackColor = false;
            this.btnNovoServico.Click += new System.EventHandler(this.btnNovoServico_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantidade: ";
            // 
            // nudUnidades
            // 
            this.nudUnidades.Location = new System.Drawing.Point(479, 39);
            this.nudUnidades.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudUnidades.Name = "nudUnidades";
            this.nudUnidades.Size = new System.Drawing.Size(66, 30);
            this.nudUnidades.TabIndex = 3;
            this.nudUnidades.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Location = new System.Drawing.Point(6, 93);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(200, 24);
            this.lblValorUnitario.TabIndex = 2;
            this.lblValorUnitario.Text = "Valor Unitario: 10€";
            // 
            // cb_Descricao
            // 
            this.cb_Descricao.FormattingEnabled = true;
            this.cb_Descricao.Items.AddRange(new object[] {
            "Area até 20m2 1h",
            "Area até 40m2 1h",
            "Area até 60m2 1h",
            "Area até 80m2 1h"});
            this.cb_Descricao.Location = new System.Drawing.Point(102, 38);
            this.cb_Descricao.Name = "cb_Descricao";
            this.cb_Descricao.Size = new System.Drawing.Size(235, 32);
            this.cb_Descricao.TabIndex = 1;
            this.cb_Descricao.SelectedIndexChanged += new System.EventHandler(this.cb_Descricao_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Servico: ";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.btnEmiteFatura);
            this.groupBox4.Controls.Add(this.btnNovaLimpeza);
            this.groupBox4.Controls.Add(this.dtpDataDaLimpeza);
            this.groupBox4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(12, 539);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1129, 81);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Emitir Fatura";
            // 
            // btnEmiteFatura
            // 
            this.btnEmiteFatura.BackColor = System.Drawing.Color.DarkGreen;
            this.btnEmiteFatura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmiteFatura.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEmiteFatura.FlatAppearance.BorderSize = 5;
            this.btnEmiteFatura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEmiteFatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmiteFatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnEmiteFatura.ForeColor = System.Drawing.Color.White;
            this.btnEmiteFatura.Location = new System.Drawing.Point(763, 26);
            this.btnEmiteFatura.Name = "btnEmiteFatura";
            this.btnEmiteFatura.Size = new System.Drawing.Size(359, 46);
            this.btnEmiteFatura.TabIndex = 29;
            this.btnEmiteFatura.Text = "Emitir Fatura ➕";
            this.btnEmiteFatura.UseVisualStyleBackColor = false;
            // 
            // btnNovaLimpeza
            // 
            this.btnNovaLimpeza.BackColor = System.Drawing.Color.DarkGreen;
            this.btnNovaLimpeza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovaLimpeza.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNovaLimpeza.FlatAppearance.BorderSize = 5;
            this.btnNovaLimpeza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnNovaLimpeza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaLimpeza.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnNovaLimpeza.ForeColor = System.Drawing.Color.White;
            this.btnNovaLimpeza.Location = new System.Drawing.Point(359, 26);
            this.btnNovaLimpeza.Name = "btnNovaLimpeza";
            this.btnNovaLimpeza.Size = new System.Drawing.Size(154, 46);
            this.btnNovaLimpeza.TabIndex = 28;
            this.btnNovaLimpeza.Text = "Novo ➕";
            this.btnNovaLimpeza.UseVisualStyleBackColor = false;
            this.btnNovaLimpeza.Click += new System.EventHandler(this.btnNovaLimpeza_Click);
            // 
            // dtpDataDaLimpeza
            // 
            this.dtpDataDaLimpeza.Location = new System.Drawing.Point(10, 33);
            this.dtpDataDaLimpeza.Name = "dtpDataDaLimpeza";
            this.dtpDataDaLimpeza.Size = new System.Drawing.Size(338, 30);
            this.dtpDataDaLimpeza.TabIndex = 0;
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.DarkRed;
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemover.FlatAppearance.BorderSize = 5;
            this.btnRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnRemover.ForeColor = System.Drawing.Color.White;
            this.btnRemover.Location = new System.Drawing.Point(6, 371);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(399, 46);
            this.btnRemover.TabIndex = 30;
            this.btnRemover.Text = "Remover ❌";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnRemoverServicos
            // 
            this.btnRemoverServicos.BackColor = System.Drawing.Color.DarkRed;
            this.btnRemoverServicos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoverServicos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemoverServicos.FlatAppearance.BorderSize = 5;
            this.btnRemoverServicos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoverServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnRemoverServicos.ForeColor = System.Drawing.Color.White;
            this.btnRemoverServicos.Location = new System.Drawing.Point(6, 464);
            this.btnRemoverServicos.Name = "btnRemoverServicos";
            this.btnRemoverServicos.Size = new System.Drawing.Size(699, 46);
            this.btnRemoverServicos.TabIndex = 31;
            this.btnRemoverServicos.Text = "Remover ❌";
            this.btnRemoverServicos.UseVisualStyleBackColor = false;
            this.btnRemoverServicos.Click += new System.EventHandler(this.btnRemoverServicos_Click);
            // 
            // GerirLimpezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1154, 631);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GerirLimpezas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerir Limpezas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GerirLimpezas_FormClosed);
            this.Load += new System.EventHandler(this.GerirLimpezas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnidades)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblInformacaoCasa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblValorUnitario;
        private System.Windows.Forms.ComboBox cb_Descricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudUnidades;
        private System.Windows.Forms.Button btnNovoServico;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnNovaLimpeza;
        private System.Windows.Forms.DateTimePicker dtpDataDaLimpeza;
        private System.Windows.Forms.Button btnEmiteFatura;
        private System.Windows.Forms.ListBox lb_ListaDeLimpezas;
        private System.Windows.Forms.ListBox lb_ListaDeServicos;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnRemoverServicos;
    }
}