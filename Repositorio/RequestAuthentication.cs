using RestSharp;

namespace SampleConciliacaoCappta
{
    public static class RequestAuthentication
    {
        public static RestRequest Open()
        {
            var request = new RestRequest(Method.GET);
            request.AddHeader("api-key", "f3e4ee3b28e229c8f0df62d6b8fec09e854ea0bbf9e394076211a354dc7052f4");
            return request;
        }
    }
}
