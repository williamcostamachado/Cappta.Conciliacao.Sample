using Cappta.Gp.Api.Conciliacao.Aplication;
using System;
using System.Windows.Forms;

namespace SampleConciliacaoCappta
{
    public partial class ConciliationForm : Form
    {
        private CapptaResponse capptaResponse;

        public ConciliationForm()
        {
            InitializeComponent();
            this.capptaResponse = new CapptaResponse();
        }

        private void ExecuteReceiptsSearch_Click(object sender, EventArgs e)
        {
            var filter = this.CreateFilter(InstallmentType.Receipts);
            if (filter.IsValid() == false) { InvalidarAutenticacao(); }

             dataGridViewSales.DataSource = capptaResponse.GetAllSales(filter); 
        }

        private void ExecuteSalesSearch_Click(object sender, EventArgs e)
        {
            var filter = this.CreateFilter(InstallmentType.Sales);
            if (filter.IsValid() == false) { InvalidarAutenticacao(); }

            dataGridViewReceipts.DataSource = capptaResponse.GetAllSales(filter);
        }

        private TransactionFilter CreateFilter(InstallmentType installmentType)
        {
            return new TransactionFilter(installmentType) {
                Cnpj = comboBoxCNPJ.SelectedItem.ToString(),
                Nsu = textBoxNsu.Text,
                FinalDate = textBoxFinal.Text,
                InitialDate = textBoxDatInicio.Text
            };
        }

        private void InvalidarAutenticacao()
        {
            Environment.Exit(1);
        }
    }
}
