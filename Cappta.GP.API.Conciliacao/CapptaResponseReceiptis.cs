namespace QuickType
{
    using Newtonsoft.Json;

    public partial class CapptaReplyReceiptis
    {
        [JsonProperty("acquirer")]
        public string Acquirer { get; set; }

        [JsonProperty("acquirerAuthorizationCode")]
        public string AcquirerAuthorizationCode { get; set; }

        [JsonProperty("bankAccount")]
        public string BankAccount { get; set; }

        [JsonProperty("bankBranch")]
        public string BankBranch { get; set; }

        [JsonProperty("bankCode")]
        public string BankCode { get; set; }

        [JsonProperty("bankName")]
        public string BankName { get; set; }

        [JsonProperty("cardBrand")]
        public string CardBrand { get; set; }

        [JsonProperty("cardBrandTax")]
        public double? CardBrandTax { get; set; }

        [JsonProperty("captureWay")]
        public string CaptureWay { get; set; }

        [JsonProperty("installmentNumber")]
        public long? InstallmentNumber { get; set; }

        [JsonProperty("grossAmount")]
        public double? GrossAmount { get; set; }

        [JsonProperty("merchantCnpj")]
        public string MerchantCnpj { get; set; }

        [JsonProperty("maturityDate")]
        public string MaturityDate { get; set; }

        [JsonProperty("netAmount")]
        public double? NetAmount { get; set; }

        [JsonProperty("nsu")]
        public string Nsu { get; set; }

        [JsonProperty("product")]
        public string Product { get; set; }

        [JsonProperty("receivingDate")]
        public string ReceivingDate { get; set; }

        [JsonProperty("saleDate")]
        public string SaleDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("transactionAmount")]
        public double? TransactionAmount { get; set; }

        [JsonProperty("transactionInstallments")]
        public long? TransactionInstallments { get; set; }

        [JsonProperty("updateDate")]
        public string UpdateDate { get; set; }
    }
}

