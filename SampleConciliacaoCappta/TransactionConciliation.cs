namespace SampleConciliacaoCappta
{
    public interface Conciliation
    {
        string cnpj { get; set; }
        string url { get; set; }
        string nsu { get; set; }
        string initialDate { get; set;}
        string finalDate { get; set; }
    }
}
