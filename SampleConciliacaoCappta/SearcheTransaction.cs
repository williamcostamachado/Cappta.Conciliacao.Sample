using RestSharp;

namespace SampleConciliacaoCappta
{
    public abstract class SearchTransaction<TypeRequest> where TypeRequest: Conciliation, new()
    {
        public abstract  string TypeSearch { get; }

        public RestClient Nsu(TypeRequest request)
        {
            var restClient = new RestClient(request.url + TypeSearch + "/" + request.cnpj + "?nsu=" + 
 request.nsu);
            return restClient;
        }

        public RestClient Date(TypeRequest request)
        {
            var restClient = new RestClient(request.url + TypeSearch + "/" + request.cnpj + "?initialDate=" +
 request.initialDate + "&finalDate=" + request.finalDate);
            return restClient;
        }
    }
}
