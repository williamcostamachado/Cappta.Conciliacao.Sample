using QuickType;
using SampleConciliacaoCappta;

namespace Cappta.Gp.Api.Conciliacao.Aplication
{
    public class CapptaResponse
    {
        public ResponseSales[] GetAllSales(TransactionFilter filter)
        {
            var search = new SearchTransaction();
            var response = search.Search(filter).Execute(RequestAuthentication.Open());

            return CapptaSalesResponse.Get.FromJson(response.Content);
        }

        public ResponseReceipts[] GetAllReceipts(TransactionFilter filter)
        {
            var search = new SearchTransaction();
            var response = search.Search(filter).Execute(RequestAuthentication.Open());

            return CapptaReceiptResponse.Get.FromJson(response.Content);
        }
    }
}
