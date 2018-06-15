using Cappta.Gp.Api.Conciliacao.Aplication;
using System;
using System.Windows.Forms;

namespace SampleConciliacaoCappta
{
    public partial class ConciliationForm : Form
    {
        private InstallmentProvider conciliation;

        public ConciliationForm()
        {
            InitializeComponent();

            this.conciliation = new InstallmentProvider();
        }

        private TransactionFilter CreateFilter(InstallmentType installmentType)
        {
            return new TransactionFilter(installmentType)
            {
                Cnpj = cnpj.SelectedItem.ToString(),
                Nsu = nsu.Text,
                FinalDate = Convert.ToDateTime(finalDate.Text),
                InitialDate = Convert.ToDateTime(initialDate.Text)
            };
        }

        private void FilterInvalidate()
        {
            Environment.Exit(1);
        }

        private void ReceiptsSearch(object sender, EventArgs e)
        {
            var filter = this.CreateFilter(InstallmentType.Sales);
            if (filter.IsValid() == false) { FilterInvalidate(); }

            dataGridViewReceipts.DataSource = conciliation.GetReceipts(filter);
        }

        private void SalesResarch(object sender, EventArgs e)
        {
            var filter = this.CreateFilter(InstallmentType.Sales);
            if (filter.IsValid() == false) { FilterInvalidate(); }

            dataGridViewSales.DataSource = conciliation.GetSales(filter);
        }

        private void checkBoxFiltrarNsu_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBoxFiltrarNsu.Checked) { panelNsu.Visible = true; }
            else { panelNsu.Visible = false; }
        }
    }
}
