namespace SampleConciliacaoCappta
{
    public class  SalesSearch : SearchTransaction<Sales>
    {      
        public override string TypeSearch
        {
            get { return "sales"; }
        }
    }
}
