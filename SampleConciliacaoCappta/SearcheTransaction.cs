using RestSharp;

namespace SampleConciliacaoCappta
{
    public class SearchTransaction
    {
        private string url;

        public SearchTransaction(string url)
        {
            this.url = url;
        }

        public RestClient Search(TransactionFilter request)
        {
            var searchUrl = $@"{this.url}/{request.QueryString}";

            var restClient = new RestClient(searchUrl);
            return restClient;
        }
    }
}
