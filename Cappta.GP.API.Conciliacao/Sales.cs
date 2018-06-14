namespace QuickType
{
    using Newtonsoft.Json;

    public partial class Sales
    {
       [JsonProperty("EstimatedGrossAmount")]
        public double? EstimatedGrossAmount { get; set; }

        [JsonProperty("EstimatedNetAmount")]
        public double? EstimatedNetAmount { get; set; }

        [JsonProperty("EstimatedCardBrandTax")]
        public double? EstimatedCardBrandTax { get; set; }

        [JsonProperty("InstallmentNumber")]
        public long? InstallmentNumber { get; set; }

        [JsonProperty("MaturityDate")]
        public System.DateTimeOffset? MaturityDate { get; set; }

        [JsonProperty("TransactionAmount")]
        public double? TransactionAmount { get; set; }

        [JsonProperty("TransactionInstallments")]
        public long? TransactionInstallments { get; set; }

        [JsonProperty("Acquirer")]
        public string Acquirer { get; set; }

        [JsonProperty("AcquirerAuthorizationCode")]
        public string AcquirerAuthorizationCode { get; set; }

        [JsonProperty("CardBrand")]
        public string CardBrand { get; set; }

        [JsonProperty("CaptureWay")]
        public string CaptureWay { get; set; }

        [JsonProperty("NSU")]
        public string Nsu { get; set; }

        [JsonProperty("MerchantCnpj")]
        public string MerchantCnpj { get; set; }

        [JsonProperty("Product")]
        public string Product { get; set; }

        [JsonProperty("SaleDate")]
        public string SaleDate { get; set; }

        [JsonProperty("Status")]
        public string Status { get; set; }

        [JsonProperty("UpdateDate")]
        public string UpdateDate { get; set; }

    }
}
