namespace Projeto_DA
{
    partial class Form2
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
            System.Windows.Forms.Label contactoLabel;
            System.Windows.Forms.Label moradaLabel;
            System.Windows.Forms.Label nifLabel;
            System.Windows.Forms.Label nomeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.clienteDataGridView = new System.Windows.Forms.DataGridView();
            this.contactoTextBox = new System.Windows.Forms.TextBox();
            this.moradaTextBox = new System.Windows.Forms.TextBox();
            this.nifTextBox = new System.Windows.Forms.TextBox();
            this.txtNome_Filter = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nomeTextBoxs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            contactoLabel = new System.Windows.Forms.Label();
            moradaLabel = new System.Windows.Forms.Label();
            nifLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // contactoLabel
            // 
            contactoLabel.AutoSize = true;
            contactoLabel.Location = new System.Drawing.Point(841, 346);
            contactoLabel.Name = "contactoLabel";
            contactoLabel.Size = new System.Drawing.Size(53, 13);
            contactoLabel.TabIndex = 4;
            contactoLabel.Text = "Contacto:";
            // 
            // moradaLabel
            // 
            moradaLabel.AutoSize = true;
            moradaLabel.Location = new System.Drawing.Point(841, 372);
            moradaLabel.Name = "moradaLabel";
            moradaLabel.Size = new System.Drawing.Size(46, 13);
            moradaLabel.TabIndex = 8;
            moradaLabel.Text = "Morada:";
            // 
            // nifLabel
            // 
            nifLabel.AutoSize = true;
            nifLabel.Location = new System.Drawing.Point(841, 445);
            nifLabel.Name = "nifLabel";
            nifLabel.Size = new System.Drawing.Size(23, 13);
            nifLabel.TabIndex = 10;
            nifLabel.Text = "Nif:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(841, 417);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 12;
            nomeLabel.Text = "Nome:";
            // 
            // clienteDataGridView
            // 
            this.clienteDataGridView.AllowUserToAddRows = false;
            this.clienteDataGridView.AllowUserToDeleteRows = false;
            this.clienteDataGridView.AutoGenerateColumns = false;
            this.clienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.clienteDataGridView.DataSource = this.clienteBindingSource;
            this.clienteDataGridView.Location = new System.Drawing.Point(14, 72);
            this.clienteDataGridView.Name = "clienteDataGridView";
            this.clienteDataGridView.ReadOnly = true;
            this.clienteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.clienteDataGridView.Size = new System.Drawing.Size(343, 727);
            this.clienteDataGridView.TabIndex = 1;
            this.clienteDataGridView.SelectionChanged += new System.EventHandler(this.clienteDataGridView_SelectionChanged);
            // 
            // contactoTextBox
            // 
            this.contactoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Contacto", true));
            this.contactoTextBox.Location = new System.Drawing.Point(934, 343);
            this.contactoTextBox.Name = "contactoTextBox";
            this.contactoTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactoTextBox.TabIndex = 5;
            // 
            // moradaTextBox
            // 
            this.moradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Morada", true));
            this.moradaTextBox.Location = new System.Drawing.Point(934, 369);
            this.moradaTextBox.Name = "moradaTextBox";
            this.moradaTextBox.Size = new System.Drawing.Size(100, 20);
            this.moradaTextBox.TabIndex = 9;
            // 
            // nifTextBox
            // 
            this.nifTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nif", true));
            this.nifTextBox.Location = new System.Drawing.Point(934, 442);
            this.nifTextBox.Name = "nifTextBox";
            this.nifTextBox.Size = new System.Drawing.Size(100, 20);
            this.nifTextBox.TabIndex = 11;
            // 
            // txtNome_Filter
            // 
            this.txtNome_Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome_Filter.Location = new System.Drawing.Point(14, 33);
            this.txtNome_Filter.Name = "txtNome_Filter";
            this.txtNome_Filter.Size = new System.Drawing.Size(287, 31);
            this.txtNome_Filter.TabIndex = 14;
            this.txtNome_Filter.TextChanged += new System.EventHandler(this.txtNome_Filter_TextChanged);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFilter.FlatAppearance.BorderSize = 2;
            this.btnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(307, 31);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(50, 35);
            this.btnFilter.TabIndex = 15;
            this.btnFilter.Text = "🔍";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.bindingNavigatorDeleteItem);
            this.groupBox1.Controls.Add(this.clienteDataGridView);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.txtNome_Filter);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 865);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clientes:";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.BackColor = System.Drawing.Color.DarkRed;
            this.bindingNavigatorDeleteItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bindingNavigatorDeleteItem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bindingNavigatorDeleteItem.FlatAppearance.BorderSize = 5;
            this.bindingNavigatorDeleteItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bindingNavigatorDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bindingNavigatorDeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.bindingNavigatorDeleteItem.ForeColor = System.Drawing.Color.White;
            this.bindingNavigatorDeleteItem.Location = new System.Drawing.Point(14, 805);
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(343, 46);
            this.bindingNavigatorDeleteItem.TabIndex = 16;
            this.bindingNavigatorDeleteItem.Text = "Remover";
            this.bindingNavigatorDeleteItem.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatAppearance.BorderSize = 5;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(13, 272);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(147, 46);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar 💾";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnNovo);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nomeTextBoxs);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(393, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 865);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalhes";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.listBox3);
            this.groupBox5.Location = new System.Drawing.Point(13, 687);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(389, 164);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Aquisições";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox2);
            this.groupBox4.Location = new System.Drawing.Point(13, 506);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(389, 164);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Arrendamentos:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Location = new System.Drawing.Point(13, 336);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 164);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Casas:";
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.DarkGreen;
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNovo.FlatAppearance.BorderSize = 5;
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnNovo.ForeColor = System.Drawing.Color.White;
            this.btnNovo.Location = new System.Drawing.Point(248, 272);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(154, 46);
            this.btnNovo.TabIndex = 26;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(13, 236);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(389, 30);
            this.textBox3.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "Contacto: ";
            // 
            // nomeTextBoxs
            // 
            this.nomeTextBoxs.Location = new System.Drawing.Point(13, 176);
            this.nomeTextBoxs.Name = "nomeTextBoxs";
            this.nomeTextBoxs.Size = new System.Drawing.Size(389, 30);
            this.nomeTextBoxs.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Morada: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(389, 30);
            this.textBox2.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nif: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(389, 30);
            this.textBox1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nome: ";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(934, 414);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomeTextBox.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(6, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(377, 124);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 24;
            this.listBox2.Location = new System.Drawing.Point(6, 29);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(377, 124);
            this.listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 24;
            this.listBox3.Location = new System.Drawing.Point(6, 29);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(377, 124);
            this.listBox3.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nif";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nif";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Contacto";
            this.dataGridViewTextBoxColumn5.HeaderText = "Contacto";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Projeto_DA.Cliente);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1049, 884);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(contactoLabel);
            this.Controls.Add(this.contactoTextBox);
            this.Controls.Add(moradaLabel);
            this.Controls.Add(this.moradaTextBox);
            this.Controls.Add(nifLabel);
            this.Controls.Add(this.nifTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.clienteDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.DataGridView clienteDataGridView;
        private System.Windows.Forms.TextBox contactoTextBox;
        private System.Windows.Forms.TextBox moradaTextBox;
        private System.Windows.Forms.TextBox nifTextBox;
        private System.Windows.Forms.TextBox txtNome_Filter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bindingNavigatorDeleteItem;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nomeTextBoxs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
    }
}