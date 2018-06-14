namespace SampleConciliacaoCappta
{
    partial class ConciliationForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageVendas = new System.Windows.Forms.TabPage();
            this.head = new System.Windows.Forms.Panel();
            this.buttonPesquisa = new System.Windows.Forms.Button();
            this.cnpj = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelNsu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nsu = new System.Windows.Forms.TextBox();
            this.panelPeriodo = new System.Windows.Forms.Panel();
            this.finalDate = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.initialDate = new System.Windows.Forms.TextBox();
            this.labelPeriodo = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.dataGridViewSales = new System.Windows.Forms.DataGridView();
            this.tabPageParcelas = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewReceipts = new System.Windows.Forms.DataGridView();
            this.pesquisar = new System.Windows.Forms.PictureBox();
            this.ExecutarPesquisa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageVendas.SuspendLayout();
            this.head.SuspendLayout();
            this.panelNsu.SuspendLayout();
            this.panelPeriodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            this.tabPageParcelas.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tabControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 701);
            this.panel1.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageVendas);
            this.tabControl.Controls.Add(this.tabPageParcelas);
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1062, 691);
            this.tabControl.TabIndex = 2;
            // 
            // tabPageVendas
            // 
            this.tabPageVendas.BackColor = System.Drawing.SystemColors.Window;
            this.tabPageVendas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageVendas.Controls.Add(this.head);
            this.tabPageVendas.Controls.Add(this.dataGridViewSales);
            this.tabPageVendas.Location = new System.Drawing.Point(4, 22);
            this.tabPageVendas.Name = "tabPageVendas";
            this.tabPageVendas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVendas.Size = new System.Drawing.Size(1054, 665);
            this.tabPageVendas.TabIndex = 0;
            this.tabPageVendas.Text = "Vendas";
            // 
            // head
            // 
            this.head.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.head.Controls.Add(this.buttonPesquisa);
            this.head.Controls.Add(this.cnpj);
            this.head.Controls.Add(this.label2);
            this.head.Controls.Add(this.panelNsu);
            this.head.Controls.Add(this.panelPeriodo);
            this.head.Controls.Add(this.labelTitulo);
            this.head.Location = new System.Drawing.Point(6, 6);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(1036, 73);
            this.head.TabIndex = 0;
            // 
            // buttonPesquisa
            // 
            this.buttonPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPesquisa.Location = new System.Drawing.Point(868, 2);
            this.buttonPesquisa.Name = "buttonPesquisa";
            this.buttonPesquisa.Size = new System.Drawing.Size(121, 61);
            this.buttonPesquisa.TabIndex = 2;
            this.buttonPesquisa.Text = "Pesquisar";
            this.buttonPesquisa.UseVisualStyleBackColor = true;
            this.buttonPesquisa.Click += new System.EventHandler(this.SalesResarch);
            // 
            // cnpj
            // 
            this.cnpj.FormattingEnabled = true;
            this.cnpj.Items.AddRange(new object[] {
            "88888888888888"});
            this.cnpj.Location = new System.Drawing.Point(49, 23);
            this.cnpj.Name = "cnpj";
            this.cnpj.Size = new System.Drawing.Size(179, 21);
            this.cnpj.TabIndex = 11;
            this.cnpj.Text = "Escolha o CNPJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "CNPJ";
            // 
            // panelNsu
            // 
            this.panelNsu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelNsu.Controls.Add(this.label1);
            this.panelNsu.Controls.Add(this.nsu);
            this.panelNsu.Location = new System.Drawing.Point(234, 6);
            this.panelNsu.Name = "panelNsu";
            this.panelNsu.Size = new System.Drawing.Size(242, 58);
            this.panelNsu.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "NSU";
            // 
            // nsu
            // 
            this.nsu.Location = new System.Drawing.Point(69, 20);
            this.nsu.Name = "nsu";
            this.nsu.Size = new System.Drawing.Size(155, 20);
            this.nsu.TabIndex = 0;
            // 
            // panelPeriodo
            // 
            this.panelPeriodo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPeriodo.Controls.Add(this.finalDate);
            this.panelPeriodo.Controls.Add(this.label);
            this.panelPeriodo.Controls.Add(this.initialDate);
            this.panelPeriodo.Controls.Add(this.labelPeriodo);
            this.panelPeriodo.Location = new System.Drawing.Point(482, 6);
            this.panelPeriodo.Name = "panelPeriodo";
            this.panelPeriodo.Size = new System.Drawing.Size(320, 56);
            this.panelPeriodo.TabIndex = 3;
            // 
            // finalDate
            // 
            this.finalDate.Location = new System.Drawing.Point(172, 21);
            this.finalDate.Name = "finalDate";
            this.finalDate.Size = new System.Drawing.Size(131, 20);
            this.finalDate.TabIndex = 4;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(143, 26);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(23, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Até";
            // 
            // initialDate
            // 
            this.initialDate.Location = new System.Drawing.Point(6, 21);
            this.initialDate.Name = "initialDate";
            this.initialDate.Size = new System.Drawing.Size(131, 20);
            this.initialDate.TabIndex = 1;
            // 
            // labelPeriodo
            // 
            this.labelPeriodo.AutoSize = true;
            this.labelPeriodo.Location = new System.Drawing.Point(3, 0);
            this.labelPeriodo.Name = "labelPeriodo";
            this.labelPeriodo.Size = new System.Drawing.Size(93, 13);
            this.labelPeriodo.TabIndex = 0;
            this.labelPeriodo.Text = "Escolha o Periodo";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelTitulo.Location = new System.Drawing.Point(3, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(169, 15);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Utilize os filtros para fazer a busca";
            // 
            // dataGridViewSales
            // 
            this.dataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSales.Location = new System.Drawing.Point(1, 125);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.Size = new System.Drawing.Size(1048, 530);
            this.dataGridViewSales.TabIndex = 1;
            // 
            // tabPageParcelas
            // 
            this.tabPageParcelas.Controls.Add(this.panel2);
            this.tabPageParcelas.Controls.Add(this.dataGridViewReceipts);
            this.tabPageParcelas.Location = new System.Drawing.Point(4, 22);
            this.tabPageParcelas.Name = "tabPageParcelas";
            this.tabPageParcelas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParcelas.Size = new System.Drawing.Size(1054, 665);
            this.tabPageParcelas.TabIndex = 1;
            this.tabPageParcelas.Text = "Parcelas e Recebimentos";
            this.tabPageParcelas.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.ExecutarPesquisa);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(6, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1035, 73);
            this.panel2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "88888888888888"});
            this.comboBox1.Location = new System.Drawing.Point(49, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.Text = "Escolha o CNPJ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "CNPJ";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(234, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(242, 58);
            this.panel3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "NSU";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(482, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(320, 56);
            this.panel4.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(172, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Até";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 21);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(131, 20);
            this.textBox3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Escolha o Periodo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Utilize os filtros para fazer a busca";
            // 
            // dataGridViewReceipts
            // 
            this.dataGridViewReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReceipts.Location = new System.Drawing.Point(3, 87);
            this.dataGridViewReceipts.Name = "dataGridViewReceipts";
            this.dataGridViewReceipts.Size = new System.Drawing.Size(1043, 570);
            this.dataGridViewReceipts.TabIndex = 3;
            // 
            // pesquisar
            // 
            this.pesquisar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pesquisar.Image = global::SampleConciliacaoCappta.Properties.Resources.pesquisa;
            this.pesquisar.Location = new System.Drawing.Point(454, 85);
            this.pesquisar.Name = "pesquisar";
            this.pesquisar.Size = new System.Drawing.Size(76, 55);
            this.pesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pesquisar.TabIndex = 7;
            this.pesquisar.TabStop = false;
            // 
            // ExecutarPesquisa
            // 
            this.ExecutarPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExecutarPesquisa.Location = new System.Drawing.Point(870, 3);
            this.ExecutarPesquisa.Name = "ExecutarPesquisa";
            this.ExecutarPesquisa.Size = new System.Drawing.Size(121, 61);
            this.ExecutarPesquisa.TabIndex = 12;
            this.ExecutarPesquisa.Text = "Pesquisar";
            this.ExecutarPesquisa.UseVisualStyleBackColor = true;
            this.ExecutarPesquisa.Click += new System.EventHandler(this.ReceiptsSearch);
            // 
            // ConciliationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 701);
            this.Controls.Add(this.panel1);
            this.Name = "ConciliationForm";
            this.Text = "Conciliação Cappta ";
            this.panel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageVendas.ResumeLayout(false);
            this.head.ResumeLayout(false);
            this.head.PerformLayout();
            this.panelNsu.ResumeLayout(false);
            this.panelNsu.PerformLayout();
            this.panelPeriodo.ResumeLayout(false);
            this.panelPeriodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            this.tabPageParcelas.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel panelNsu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nsu;
        private System.Windows.Forms.Panel panelPeriodo;
        private System.Windows.Forms.TextBox finalDate;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox initialDate;
        private System.Windows.Forms.Label labelPeriodo;
        private System.Windows.Forms.PictureBox pesquisar;
        private System.Windows.Forms.DataGridView dataGridViewSales;
        private System.Windows.Forms.ComboBox cnpj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageVendas;
        private System.Windows.Forms.TabPage tabPageParcelas;
        private System.Windows.Forms.Button buttonPesquisa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewReceipts;
        private System.Windows.Forms.Button ExecutarPesquisa;
    }
}

