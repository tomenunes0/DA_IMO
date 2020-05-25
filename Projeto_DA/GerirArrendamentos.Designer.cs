namespace Projeto_DA
{
    partial class GerirArrendamentos
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
            this.btnRemover = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblProprietario = new System.Windows.Forms.Label();
            this.lblLocalidade = new System.Windows.Forms.Label();
            this.lblIdCasa = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbListaAlugeres = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbArrendatario = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnNovoServico = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
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
            this.btnRemover.Location = new System.Drawing.Point(113, 288);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(350, 46);
            this.btnRemover.TabIndex = 19;
            this.btnRemover.Text = "Remover ❌";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblProprietario);
            this.groupBox1.Controls.Add(this.lblLocalidade);
            this.groupBox1.Controls.Add(this.lblIdCasa);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(981, 140);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhes Casa:";
            // 
            // lblProprietario
            // 
            this.lblProprietario.AutoSize = true;
            this.lblProprietario.Location = new System.Drawing.Point(6, 106);
            this.lblProprietario.Name = "lblProprietario";
            this.lblProprietario.Size = new System.Drawing.Size(381, 24);
            this.lblProprietario.TabIndex = 2;
            this.lblProprietario.Text = "Proprietario: Samuel Brás (852693147)";
            // 
            // lblLocalidade
            // 
            this.lblLocalidade.AutoSize = true;
            this.lblLocalidade.Location = new System.Drawing.Point(6, 71);
            this.lblLocalidade.Name = "lblLocalidade";
            this.lblLocalidade.Size = new System.Drawing.Size(300, 24);
            this.lblLocalidade.TabIndex = 1;
            this.lblLocalidade.Text = "Localidade: Leiria Leiria 98 2";
            // 
            // lblIdCasa
            // 
            this.lblIdCasa.AutoSize = true;
            this.lblIdCasa.Location = new System.Drawing.Point(6, 37);
            this.lblIdCasa.Name = "lblIdCasa";
            this.lblIdCasa.Size = new System.Drawing.Size(60, 24);
            this.lblIdCasa.TabIndex = 0;
            this.lblIdCasa.Text = "ID: 1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.lbListaAlugeres);
            this.groupBox2.Controls.Add(this.btnRemover);
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(12, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(604, 361);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de Alugueres:";
            // 
            // lbListaAlugeres
            // 
            this.lbListaAlugeres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbListaAlugeres.ForeColor = System.Drawing.Color.White;
            this.lbListaAlugeres.FormattingEnabled = true;
            this.lbListaAlugeres.ItemHeight = 24;
            this.lbListaAlugeres.Location = new System.Drawing.Point(10, 29);
            this.lbListaAlugeres.Name = "lbListaAlugeres";
            this.lbListaAlugeres.Size = new System.Drawing.Size(581, 244);
            this.lbListaAlugeres.TabIndex = 20;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.cbArrendatario);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.btnNovoServico);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(622, 158);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(371, 361);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Novo Contrato";
            // 
            // cbArrendatario
            // 
            this.cbArrendatario.FormattingEnabled = true;
            this.cbArrendatario.Location = new System.Drawing.Point(10, 250);
            this.cbArrendatario.Name = "cbArrendatario";
            this.cbArrendatario.Size = new System.Drawing.Size(351, 32);
            this.cbArrendatario.TabIndex = 33;
            this.cbArrendatario.SelectedIndexChanged += new System.EventHandler(this.cbArrendatario_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "Arrendatário:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(10, 192);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 28);
            this.checkBox1.TabIndex = 31;
            this.checkBox1.Text = "Renovável";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(10, 156);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(351, 30);
            this.numericUpDown1.TabIndex = 30;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(351, 30);
            this.dateTimePicker1.TabIndex = 29;
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
            this.btnNovoServico.Location = new System.Drawing.Point(122, 288);
            this.btnNovoServico.Name = "btnNovoServico";
            this.btnNovoServico.Size = new System.Drawing.Size(154, 46);
            this.btnNovoServico.TabIndex = 28;
            this.btnNovoServico.Text = "Novo ➕";
            this.btnNovoServico.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Duração (meses):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inicio do Contrato:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID: 1";
            // 
            // GerirArrendamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1004, 530);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GerirArrendamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GerirArrendamentos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblProprietario;
        private System.Windows.Forms.Label lblLocalidade;
        private System.Windows.Forms.Label lblIdCasa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbListaAlugeres;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNovoServico;
        private System.Windows.Forms.ComboBox cbArrendatario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}