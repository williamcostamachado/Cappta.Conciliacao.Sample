using RestSharp;
using SampleConciliacaoCappta;

namespace Cappta.Gp.Api.Conciliacao.Aplication
{
    public class SearchTransaction
    {
        private string url;

        public SearchTransaction()
        {
            this.url = "https://conciliacao-api.cappta.com.br/api/v1/";
        }

        public RestClient Search(TransactionFilter request)
        {
            var searchUrl = $@"{this.url}/{request.QueryString}";

            var restClient = new RestClient(searchUrl);
            return restClient;
        }
    }
}
