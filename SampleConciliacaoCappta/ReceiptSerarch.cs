namespace SampleConciliacaoCappta
{
    class ReceiptSerarch : SearchTransaction<Receipt>
    {
        public override string TypeSearch
        {
            get { return "receipt"; }
        }
    }
}
