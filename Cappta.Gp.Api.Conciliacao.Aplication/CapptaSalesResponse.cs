using Cappta.Gp.APi.Conciliacao.Infrastructure;
using Newtonsoft.Json;
using QuickType;
using SampleConciliacaoCappta;
using System.Collections.Generic;

namespace Cappta.Gp.Api.Conciliacao.Aplication
{
    public static class SaleResponseProvider
    {
        public static IEnumerable<Sales> FindByFilter(TransactionFilter filter)
        {
            var search = new SearchTransaction();
            var response = search.Search(filter).Execute(RequestAuthentication.Open());
            var sales = JsonConvert.DeserializeObject<Sales[]>(response.Content);

            return sales;     
        }
    }
}
