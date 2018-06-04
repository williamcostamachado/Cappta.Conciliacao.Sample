using System;
using System.Windows.Forms;
using Cappta.Gp.Api.Conciliacao.Aplication;

namespace SampleConciliacaoCappta
{
    public partial class ConciliationForm : Form
    {
       
        public ConciliationForm()
        {
            InitializeComponent();
        }

        private void BtnSearch(object sender, EventArgs e)
        {
            var installmentType = radioButtonSales.Checked
                ? InstallmentType.Sales
                : InstallmentType.Receipts;

            var filter = this.CreateFilter(installmentType);
            if (filter.IsValid() == false) { InvalidarAutenticacao(); }

            var searchTransaction = new SearchTransaction();
            
            var response = searchTransaction.Search(filter).Execute(RequestAuthentication.Open());

            dataGridViewResultado.DataSource = CapptaSalesResponse.Get.FromJson(response.Content);
            
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

        private void CriarMensagemErroJanela(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro");
        }

    }
}
