using Cappta.Gp.APi.Conciliacao.Infrastructure;
using Newtonsoft.Json;
using QuickType;
using SampleConciliacaoCappta;
using System.Collections.Generic;

namespace Cappta.Gp.Api.Conciliacao.Aplication
{
    public static class CapptaReceiptResponse
    {
       public static IEnumerable<Receipts> GetReceipts(TransactionFilter filter)
        {
            var search = new SearchTransaction();
            var response = search.Search(filter).Execute(RequestAuthentication.Open());
            var getReceipts = JsonConvert.DeserializeObject<Receipts[]>(response.Content);

            return getReceipts;
        }

    }
}
