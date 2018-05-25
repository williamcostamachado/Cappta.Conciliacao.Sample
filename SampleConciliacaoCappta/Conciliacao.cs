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

        private void Search(object sender, EventArgs e)
        {
            var filter = this.CreateFilter(InstallmentType.Sales);
            if (filter.IsValid() == false) { InvalidarAutenticacao(); }

            var searchTransaction = new SearchTransaction();
            var response = searchTransaction.Search(filter).Execute(RequestAuthentication.Open());
            dataGridViewResultado.DataSource = CapptaSalesResponse.Get.FromJson(response.Content);
 
        }

        private TransactionFilter CreateFilter(InstallmentType type)
        {
            var transactionFilter = new TransactionFilter(InstallmentType.Sales);// isso aqui tem que virar uma linha. Como popular este objeto?
            transactionFilter.Cnpj = comboBoxCNPJ.SelectedItem.ToString();
            transactionFilter.Nsu = textBoxNsu.Text;
            transactionFilter.FinalDate = textBoxFinal.Text;
            transactionFilter.InitialDate = textBoxDatInicio.Text;

            return transactionFilter;
        }

        private void InvalidarAutenticacao()
        {
            Environment.Exit(1);
        }

        private void CriarMensagemErroJanela(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro");
        }

        private void OnradioButtonNsu_CheckedChanged(object sender, EventArgs e)
        {
            this.panelPeriodo.Hide();
            this.panelNsu.Show();
        }

        private void OnradioButtonData_CheckedChanged(object sender, EventArgs e)
        {
            this.panelNsu.Hide();
            this.panelPeriodo.Show();
        }

        private void ConciliationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
