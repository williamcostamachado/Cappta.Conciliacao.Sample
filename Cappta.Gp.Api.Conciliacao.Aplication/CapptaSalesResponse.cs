using Newtonsoft.Json;
using QuickType;

namespace Cappta.Gp.Api.Conciliacao.Aplication
{
    public static class CapptaSalesResponse
    {
        public class Get
        {
            public static ResponseSales[] FromJson(string json) => JsonConvert.DeserializeObject<ResponseSales[]>(json);
        }

    }
}
