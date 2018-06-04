using Newtonsoft.Json;
using QuickType;

namespace Cappta.Gp.Api.Conciliacao.Aplication
{
    public class CapptaReceiptResponse
    {
        public partial class Get
        {
            public static ResponseReceipts[] FromJson(string json) => JsonConvert.DeserializeObject<ResponseReceipts[]>(json);
        }
    }
}
