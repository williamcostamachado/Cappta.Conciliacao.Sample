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
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonData = new System.Windows.Forms.RadioButton();
            this.radioButtonNsu = new System.Windows.Forms.RadioButton();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.comboBoxCNPJ = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelNsu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNsu = new System.Windows.Forms.TextBox();
            this.panelPeriodo = new System.Windows.Forms.Panel();
            this.textBoxFinal = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.textBoxDatInicio = new System.Windows.Forms.TextBox();
            this.labelPeriodo = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.dataGridViewResultado = new System.Windows.Forms.DataGridView();
            this.tabPageParcelas = new System.Windows.Forms.TabPage();
            this.pesquisar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageVendas.SuspendLayout();
            this.head.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelNsu.SuspendLayout();
            this.panelPeriodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultado)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1415, 701);
            this.panel1.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageVendas);
            this.tabControl.Controls.Add(this.tabPageParcelas);
            this.tabControl.Location = new System.Drawing.Point(10, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1391, 691);
            this.tabControl.TabIndex = 2;
            // 
            // tabPageVendas
            // 
            this.tabPageVendas.BackColor = System.Drawing.SystemColors.Window;
            this.tabPageVendas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageVendas.Controls.Add(this.head);
            this.tabPageVendas.Controls.Add(this.dataGridViewResultado);
            this.tabPageVendas.Location = new System.Drawing.Point(4, 22);
            this.tabPageVendas.Name = "tabPageVendas";
            this.tabPageVendas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVendas.Size = new System.Drawing.Size(1383, 665);
            this.tabPageVendas.TabIndex = 0;
            this.tabPageVendas.Text = "Vendas";
            // 
            // head
            // 
            this.head.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.head.Controls.Add(this.buttonPesquisa);
            this.head.Controls.Add(this.panel2);
            this.head.Controls.Add(this.comboBoxCNPJ);
            this.head.Controls.Add(this.label2);
            this.head.Controls.Add(this.panelNsu);
            this.head.Controls.Add(this.panelPeriodo);
            this.head.Controls.Add(this.labelTitulo);
            this.head.Location = new System.Drawing.Point(6, 6);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(1367, 73);
            this.head.TabIndex = 0;
            // 
            // buttonPesquisa
            // 
            this.buttonPesquisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPesquisa.Location = new System.Drawing.Point(1239, 0);
            this.buttonPesquisa.Name = "buttonPesquisa";
            this.buttonPesquisa.Size = new System.Drawing.Size(121, 61);
            this.buttonPesquisa.TabIndex = 2;
            this.buttonPesquisa.Text = "Pesquisar";
            this.buttonPesquisa.UseVisualStyleBackColor = true;
            this.buttonPesquisa.Click += new System.EventHandler(this.Search);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.radioButtonData);
            this.panel2.Controls.Add(this.radioButtonNsu);
            this.panel2.Controls.Add(this.labelFiltro);
            this.panel2.Location = new System.Drawing.Point(269, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 58);
            this.panel2.TabIndex = 7;
            // 
            // radioButtonData
            // 
            this.radioButtonData.AutoSize = true;
            this.radioButtonData.Location = new System.Drawing.Point(161, 23);
            this.radioButtonData.Name = "radioButtonData";
            this.radioButtonData.Size = new System.Drawing.Size(48, 17);
            this.radioButtonData.TabIndex = 6;
            this.radioButtonData.Text = "Data";
            this.radioButtonData.UseVisualStyleBackColor = true;
            this.radioButtonData.CheckedChanged += new System.EventHandler(this.OnradioButtonData_CheckedChanged);
            // 
            // radioButtonNsu
            // 
            this.radioButtonNsu.AutoSize = true;
            this.radioButtonNsu.Checked = true;
            this.radioButtonNsu.Location = new System.Drawing.Point(12, 22);
            this.radioButtonNsu.Name = "radioButtonNsu";
            this.radioButtonNsu.Size = new System.Drawing.Size(48, 17);
            this.radioButtonNsu.TabIndex = 5;
            this.radioButtonNsu.TabStop = true;
            this.radioButtonNsu.Text = "NSU";
            this.radioButtonNsu.UseVisualStyleBackColor = true;
            this.radioButtonNsu.CheckedChanged += new System.EventHandler(this.OnradioButtonNsu_CheckedChanged);
            // 
            // labelFiltro
            // 
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.Location = new System.Drawing.Point(3, 0);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(94, 13);
            this.labelFiltro.TabIndex = 4;
            this.labelFiltro.Text = "Filtre sua pesquisa";
            this.labelFiltro.UseWaitCursor = true;
            // 
            // comboBoxCNPJ
            // 
            this.comboBoxCNPJ.FormattingEnabled = true;
            this.comboBoxCNPJ.Items.AddRange(new object[] {
            "88888888888888"});
            this.comboBoxCNPJ.Location = new System.Drawing.Point(49, 23);
            this.comboBoxCNPJ.Name = "comboBoxCNPJ";
            this.comboBoxCNPJ.Size = new System.Drawing.Size(179, 21);
            this.comboBoxCNPJ.TabIndex = 11;
            this.comboBoxCNPJ.Text = "Escolha o CNPJ";
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
            this.panelNsu.Controls.Add(this.textBoxNsu);
            this.panelNsu.Location = new System.Drawing.Point(665, 3);
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
            // textBoxNsu
            // 
            this.textBoxNsu.Location = new System.Drawing.Point(69, 20);
            this.textBoxNsu.Name = "textBoxNsu";
            this.textBoxNsu.Size = new System.Drawing.Size(155, 20);
            this.textBoxNsu.TabIndex = 0;
            // 
            // panelPeriodo
            // 
            this.panelPeriodo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPeriodo.Controls.Add(this.textBoxFinal);
            this.panelPeriodo.Controls.Add(this.label);
            this.panelPeriodo.Controls.Add(this.textBoxDatInicio);
            this.panelPeriodo.Controls.Add(this.labelPeriodo);
            this.panelPeriodo.Location = new System.Drawing.Point(913, 3);
            this.panelPeriodo.Name = "panelPeriodo";
            this.panelPeriodo.Size = new System.Drawing.Size(320, 56);
            this.panelPeriodo.TabIndex = 3;
            // 
            // textBoxFinal
            // 
            this.textBoxFinal.Location = new System.Drawing.Point(172, 21);
            this.textBoxFinal.Name = "textBoxFinal";
            this.textBoxFinal.Size = new System.Drawing.Size(131, 20);
            this.textBoxFinal.TabIndex = 4;
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
            // textBoxDatInicio
            // 
            this.textBoxDatInicio.Location = new System.Drawing.Point(6, 21);
            this.textBoxDatInicio.Name = "textBoxDatInicio";
            this.textBoxDatInicio.Size = new System.Drawing.Size(131, 20);
            this.textBoxDatInicio.TabIndex = 1;
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
            // dataGridViewResultado
            // 
            this.dataGridViewResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultado.Location = new System.Drawing.Point(6, 85);
            this.dataGridViewResultado.Name = "dataGridViewResultado";
            this.dataGridViewResultado.Size = new System.Drawing.Size(1367, 570);
            this.dataGridViewResultado.TabIndex = 1;
            // 
            // tabPageParcelas
            // 
            this.tabPageParcelas.Location = new System.Drawing.Point(4, 22);
            this.tabPageParcelas.Name = "tabPageParcelas";
            this.tabPageParcelas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParcelas.Size = new System.Drawing.Size(1383, 665);
            this.tabPageParcelas.TabIndex = 1;
            this.tabPageParcelas.Text = "Parcelas e Recebimentos";
            this.tabPageParcelas.UseVisualStyleBackColor = true;
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
            // Conciliacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 701);
            this.Controls.Add(this.panel1);
            this.Name = "Conciliacao";
            this.Text = "Conciliação Cappta ";
            this.panel1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageVendas.ResumeLayout(false);
            this.head.ResumeLayout(false);
            this.head.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelNsu.ResumeLayout(false);
            this.panelNsu.PerformLayout();
            this.panelPeriodo.ResumeLayout(false);
            this.panelPeriodo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel panelNsu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNsu;
        private System.Windows.Forms.Panel panelPeriodo;
        private System.Windows.Forms.TextBox textBoxFinal;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBoxDatInicio;
        private System.Windows.Forms.Label labelPeriodo;
        private System.Windows.Forms.PictureBox pesquisar;
        private System.Windows.Forms.DataGridView dataGridViewResultado;
        private System.Windows.Forms.ComboBox comboBoxCNPJ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageVendas;
        private System.Windows.Forms.TabPage tabPageParcelas;
        private System.Windows.Forms.Button buttonPesquisa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonData;
        private System.Windows.Forms.RadioButton radioButtonNsu;
        private System.Windows.Forms.Label labelFiltro;
    }
}

