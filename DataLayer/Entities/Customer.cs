namespace SalesPortalDL.Entities
{
    public class Customer
    {
        public int customerId { get; set; }
        public string name { get; set; }
        public string emailAddress { get; set; }

        public List<PurchaseDetail> PurchaseDetails { get; set; }

    }
}