
namespace SalesPortalDL.Entities
{
    public class PurchaseDetail
    {
        public int purchaseId { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Product> Products { get; set; }
        public int quantity { get; set; }
        public decimal amount { get; set; }
        public DateTime purchaseDate { get; set; }
    }
}