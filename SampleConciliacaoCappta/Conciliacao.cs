using System;
using System.Windows.Forms;
using QuickType;


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
            var sales = this.CreateFilter(InstallmentType.Sales);
            if (sales.IsValid() == false) { InvalidarAutenticacao(); }

            var salesResearch = new SearchTransaction("https://conciliacao-api.cappta.com.br/api/v1/");

            var response = salesResearch.Search(sales).Execute(RequestAuthentication.Open());
            var responseContent = response.Content;

            dataGridViewResultado.DataSource = CapptaReplySales.FromJson(responseContent);
        }

        private TransactionFilter CreateFilter(InstallmentType type)
        {
            var sales = new TransactionFilter(InstallmentType.Sales);// isso aqui tem que virar uma linha. Como popular este objeto?
            sales.Cnpj = comboBoxCNPJ.SelectedItem.ToString();
            sales.Nsu = textBoxNsu.Text;
            sales.FinalDate = textBoxFinal.Text;
            sales.InitialDate = textBoxDatInicio.Text;

            return sales;
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
    }
}
