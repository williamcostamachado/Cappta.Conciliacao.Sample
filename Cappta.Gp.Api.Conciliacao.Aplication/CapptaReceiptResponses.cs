using Newtonsoft.Json;

namespace Cappta.Gp.Api.Conciliacao.Aplication
{
    class CapptaReceiptResponse
    {
        public partial class CapptaReplyReceiptis
        {
            public static CapptaReplyReceiptis[] FromJson(string json) => JsonConvert.DeserializeObject<CapptaReplyReceiptis[]>(json);
        }
    }
}
