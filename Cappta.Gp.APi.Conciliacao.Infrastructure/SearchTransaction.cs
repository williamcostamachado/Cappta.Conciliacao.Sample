using RestSharp;
using SampleConciliacaoCappta;

namespace Cappta.Gp.APi.Conciliacao.Infrastructure
{
    public class SearchTransaction 
    {
        private string url;
 
        public SearchTransaction()
        {
            this.url = "https://conciliacao-api.cappta.com.br/api/v1/";       
        }

        public RestClient Search(TransactionFilter transactionFilter)
        {
            var searchUrl = $@"{this.url}/{transactionFilter.QueryString}";

            var restClient = new RestClient(searchUrl);

            return restClient;
        }
    }
}
