using QuickType;
using SampleConciliacaoCappta;
using System.Collections.Generic;

namespace Cappta.Gp.Api.Conciliacao.Aplication
{
    public class InstallmentProvider
    {
        public IEnumerable<Sales> GetSales(TransactionFilter filter)
        {
            return SaleResponseProvider.FindByFilter(filter);
        }

        public IEnumerable<Receipts> GetReceipts(TransactionFilter filter)
        {
            return CapptaReceiptResponse.GetReceipts(filter);
        }
    }
}
