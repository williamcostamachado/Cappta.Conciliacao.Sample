namespace SampleConciliacaoCappta
{
    public class Sales : Conciliation
    {
        public string cnpj { get; set; }  
        public string finalDate { get; set; }
        public string initialDate { get; set; }
        public string nsu { get; set; }
        public string url { get; set; }
    }
}
