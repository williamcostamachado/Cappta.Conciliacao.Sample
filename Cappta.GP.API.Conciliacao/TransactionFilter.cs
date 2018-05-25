using System;
using System.Text;

namespace SampleConciliacaoCappta
{
    public class TransactionFilter 
    {
        public TransactionFilter(InstallmentType type)
        {
            if (type == InstallmentType.Undefined) { throw new ArgumentException(nameof(type)); }
            this.InstallmentType = type;
        }

        public string Cnpj { get; set; }  
        public string FinalDate { get; set; }
        public string InitialDate { get; set; }
        public string Nsu { get; set; }
        public InstallmentType InstallmentType { get; private set; }

        public bool IsValid()
        {
            var initialDateIsValid = this.IsValidDateTime(this.InitialDate);
            var finalDateIsValid = this.IsValidDateTime(this.InitialDate);

            return this.HasValidCnpj() && initialDateIsValid && finalDateIsValid;
        }

        private bool HasValidCnpj()
        {
            return String.IsNullOrWhiteSpace(this.Cnpj) == false || this.Cnpj.Length == 14;
        }

        private bool HasValidNsu()
        {
            return String.IsNullOrWhiteSpace(this.Nsu) == false || this.Nsu.Length == 6;
        }

        private bool IsValidDateTime(string stringFiedDate)
        {
            DateTime convertedDate;
            return DateTime.TryParse(this.InitialDate, out convertedDate);
        }

        public string QueryString
        {
            get
            {
                var urlBuilder = new StringBuilder();

                urlBuilder.Append($"{InstallmentType.ToString()}/");
                urlBuilder.Append(this.Cnpj);
                urlBuilder.Append($"?initialDate={this.InitialDate}");
                urlBuilder.Append($"&finalDate={this.FinalDate}");

                if (this.HasValidNsu()) { urlBuilder.Append($"&nsu={this.Nsu}"); }

                return urlBuilder.ToString();
            }
        }
    }
}
