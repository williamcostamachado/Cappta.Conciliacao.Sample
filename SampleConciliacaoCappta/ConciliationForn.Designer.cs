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
            this.head = new System.Windows.Forms.Panel();
            this.checkBoxFiltrarNsu = new System.Windows.Forms.CheckBox();
            this.cnpj = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelNsu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nsu = new System.Windows.Forms.TextBox();
            this.panelPeriodo = new System.Windows.Forms.Panel();
            this.finalDate = new System.Windows.Forms.MaskedTextBox();
            this.initialDate = new System.Windows.Forms.MaskedTextBox();
            this.label = new System.Windows.Forms.Label();
            this.labelPeriodo = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageVendas = new System.Windows.Forms.TabPage();
            this.dataGridViewSales = new System.Windows.Forms.DataGridView();
            this.buttonPesquisa = new System.Windows.Forms.Button();
            this.tabPageParcelas = new System.Windows.Forms.TabPage();
            this.btnPesquisaReceipt = new System.Windows.Forms.Button();
            this.dataGridViewReceipts = new System.Windows.Forms.DataGridView();
            this.pesquisar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.head.SuspendLayout();
            this.panelNsu.SuspendLayout();
            this.panelPeriodo.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            this.tabPageParcelas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.head);
            this.panel1.Controls.Add(this.tabControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 701);
            this.panel1.TabIndex = 0;
            // 
            // head
            // 
            this.head.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.head.Controls.Add(this.checkBoxFiltrarNsu);
            this.head.Controls.Add(this.cnpj);
            this.head.Controls.Add(this.label2);
            this.head.Controls.Add(this.panelNsu);
            this.head.Controls.Add(this.panelPeriodo);
            this.head.Controls.Add(this.labelTitulo);
            this.head.Location = new System.Drawing.Point(3, 3);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(1036, 73);
            this.head.TabIndex = 2;
            // 
            // checkBoxFiltrarNsu
            // 
            this.checkBoxFiltrarNsu.AutoSize = true;
            this.checkBoxFiltrarNsu.Location = new System.Drawing.Point(641, 9);
            this.checkBoxFiltrarNsu.Name = "checkBoxFiltrarNsu";
            this.checkBoxFiltrarNsu.Size = new System.Drawing.Size(96, 17);
            this.checkBoxFiltrarNsu.TabIndex = 13;
            this.checkBoxFiltrarNsu.Text = "Filtrar Por NSU";
            this.checkBoxFiltrarNsu.UseVisualStyleBackColor = true;
            this.checkBoxFiltrarNsu.CheckedChanged += new System.EventHandler(this.checkBoxFiltrarNsu_CheckedChanged_1);
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
            this.cnpj.Text = "88888888888888";
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
            this.panelNsu.Location = new System.Drawing.Point(748, 3);
            this.panelNsu.Name = "panelNsu";
            this.panelNsu.Size = new System.Drawing.Size(118, 58);
            this.panelNsu.TabIndex = 6;
            this.panelNsu.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "NSU";
            // 
            // nsu
            // 
            this.nsu.Location = new System.Drawing.Point(39, 25);
            this.nsu.Name = "nsu";
            this.nsu.Size = new System.Drawing.Size(65, 20);
            this.nsu.TabIndex = 0;
            // 
            // panelPeriodo
            // 
            this.panelPeriodo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPeriodo.Controls.Add(this.finalDate);
            this.panelPeriodo.Controls.Add(this.initialDate);
            this.panelPeriodo.Controls.Add(this.label);
            this.panelPeriodo.Controls.Add(this.labelPeriodo);
            this.panelPeriodo.Location = new System.Drawing.Point(315, 6);
            this.panelPeriodo.Name = "panelPeriodo";
            this.panelPeriodo.Size = new System.Drawing.Size(320, 56);
            this.panelPeriodo.TabIndex = 3;
            // 
            // finalDate
            // 
            this.finalDate.Location = new System.Drawing.Point(189, 25);
            this.finalDate.Mask = "00/00/0000";
            this.finalDate.Name = "finalDate";
            this.finalDate.Size = new System.Drawing.Size(77, 20);
            this.finalDate.TabIndex = 3;
            this.finalDate.ValidatingType = typeof(System.DateTime);
            // 
            // initialDate
            // 
            this.initialDate.Location = new System.Drawing.Point(3, 25);
            this.initialDate.Mask = "00/00/0000";
            this.initialDate.Name = "initialDate";
            this.initialDate.Size = new System.Drawing.Size(81, 20);
            this.initialDate.TabIndex = 2;
            this.initialDate.ValidatingType = typeof(System.DateTime);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(130, 32);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(23, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Até";
            // 
            // labelPeriodo
            // 
            this.labelPeriodo.AutoSize = true;
            this.labelPeriodo.Location = new System.Drawing.Point(3, 3);
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
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageVendas);
            this.tabControl.Controls.Add(this.tabPageParcelas);
            this.tabControl.Location = new System.Drawing.Point(3, 82);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1062, 612);
            this.tabControl.TabIndex = 2;
            // 
            // tabPageVendas
            // 
            this.tabPageVendas.BackColor = System.Drawing.SystemColors.Window;
            this.tabPageVendas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageVendas.Controls.Add(this.dataGridViewSales);
            this.tabPageVendas.Controls.Add(this.buttonPesquisa);
            this.tabPageVendas.Location = new System.Drawing.Point(4, 22);
            this.tabPageVendas.Name = "tabPageVendas";
            this.tabPageVendas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVendas.Size = new System.Drawing.Size(1054, 586);
            this.tabPageVendas.TabIndex = 0;
            this.tabPageVendas.Text = "Vendas";
            // 
            // dataGridViewSales
            // 
            this.dataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSales.Location = new System.Drawing.Point(1, 34);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.Size = new System.Drawing.Size(1048, 550);
            this.dataGridViewSales.TabIndex = 1;
            // 
            // buttonPesquisa
            // 
            this.buttonPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisa.Location = new System.Drawing.Point(6, 5);
            this.buttonPesquisa.Name = "buttonPesquisa";
            this.buttonPesquisa.Size = new System.Drawing.Size(96, 24);
            this.buttonPesquisa.TabIndex = 2;
            this.buttonPesquisa.Text = "Pesquisar";
            this.buttonPesquisa.UseVisualStyleBackColor = true;
            this.buttonPesquisa.Click += new System.EventHandler(this.SalesResarch);
            // 
            // tabPageParcelas
            // 
            this.tabPageParcelas.Controls.Add(this.btnPesquisaReceipt);
            this.tabPageParcelas.Controls.Add(this.dataGridViewReceipts);
            this.tabPageParcelas.Location = new System.Drawing.Point(4, 22);
            this.tabPageParcelas.Name = "tabPageParcelas";
            this.tabPageParcelas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParcelas.Size = new System.Drawing.Size(1054, 586);
            this.tabPageParcelas.TabIndex = 1;
            this.tabPageParcelas.Text = "Parcelas e Recebimentos";
            this.tabPageParcelas.UseVisualStyleBackColor = true;
            // 
            // btnPesquisaReceipt
            // 
            this.btnPesquisaReceipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesquisaReceipt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisaReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisaReceipt.Location = new System.Drawing.Point(8, 6);
            this.btnPesquisaReceipt.Name = "btnPesquisaReceipt";
            this.btnPesquisaReceipt.Size = new System.Drawing.Size(96, 24);
            this.btnPesquisaReceipt.TabIndex = 4;
            this.btnPesquisaReceipt.Text = "Pesquisar";
            this.btnPesquisaReceipt.UseVisualStyleBackColor = true;
            this.btnPesquisaReceipt.Click += new System.EventHandler(this.ReceiptsSearch);
            // 
            // dataGridViewReceipts
            // 
            this.dataGridViewReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReceipts.Location = new System.Drawing.Point(3, 34);
            this.dataGridViewReceipts.Name = "dataGridViewReceipts";
            this.dataGridViewReceipts.Size = new System.Drawing.Size(1043, 557);
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
            // ConciliationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 701);
            this.Controls.Add(this.panel1);
            this.Name = "ConciliationForm";
            this.Text = "Conciliação Cappta ";
            this.panel1.ResumeLayout(false);
            this.head.ResumeLayout(false);
            this.head.PerformLayout();
            this.panelNsu.ResumeLayout(false);
            this.panelNsu.PerformLayout();
            this.panelPeriodo.ResumeLayout(false);
            this.panelPeriodo.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPageVendas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            this.tabPageParcelas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pesquisar;
        private System.Windows.Forms.DataGridView dataGridViewSales;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageVendas;
        private System.Windows.Forms.TabPage tabPageParcelas;
        private System.Windows.Forms.DataGridView dataGridViewReceipts;
        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.CheckBox checkBoxFiltrarNsu;
        private System.Windows.Forms.Button buttonPesquisa;
        private System.Windows.Forms.ComboBox cnpj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelNsu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nsu;
        private System.Windows.Forms.Panel panelPeriodo;
        private System.Windows.Forms.MaskedTextBox finalDate;
        private System.Windows.Forms.MaskedTextBox initialDate;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelPeriodo;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button btnPesquisaReceipt;
    }
}

