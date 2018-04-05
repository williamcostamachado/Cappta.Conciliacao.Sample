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
            var cnpj = comboBoxCNPJ.SelectedItem.ToString();
          
            if(radioButtonNsu.Checked == true & radioButtonData.Checked == false)
            {
                var nsu = textBoxNsu.Text;
                if (String.IsNullOrEmpty(nsu)) { InvalidarAutenticacao(); }

                var salesResearch = new SalesSearch();
                var sales = new Sales()
                {
                    cnpj = cnpj,
                    url = "https://conciliacao-api.cappta.com.br/api/v1/",
                    nsu = textBoxNsu.Text,
                    finalDate = textBoxFinal.Text,
                    initialDate = textBoxDatInicio.Text
                };

                var response = salesResearch.Nsu(sales).Execute(RequestAuthentication.Open());
                var responseContent = response.Content;
                
                dataGridViewResultado.DataSource = CapptaReplySales.FromJson(responseContent);
            }
            if (radioButtonNsu.Checked == false & radioButtonData.Checked == true)
            {
                var dataInicio = textBoxDatInicio.Text;
                if (String.IsNullOrEmpty(dataInicio)) { InvalidarAutenticacao(); }

                var dataFinal = textBoxFinal.Text;
                if (String.IsNullOrEmpty(dataFinal)) { InvalidarAutenticacao(); }

                var salesResearch = new SalesSearch();
                var sales = new Sales()
                {
                    cnpj = cnpj,
                    url = "https://conciliacao-api.cappta.com.br/api/v1/",
                    nsu = textBoxNsu.Text,
                    finalDate = textBoxFinal.Text,
                    initialDate = textBoxDatInicio.Text
                };
                var response = salesResearch.Date(sales).Execute(RequestAuthentication.Open());
                var responseContent = response.Content;

                dataGridViewResultado.DataSource = CapptaReplySales.FromJson(responseContent);
            }
        
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
