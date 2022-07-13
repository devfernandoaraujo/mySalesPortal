using SalesPortalDL.Entities;
using SalesPortalDL.DataConnection;
using Microsoft.Extensions.Configuration;

namespace SalesPortalBL
{
    public class CustomersBL
    {

        private readonly SalesPortalContext _dbConnection;
        public CustomersBL(IConfiguration configuration)
        {
            this._dbConnection = new SalesPortalContext(configuration);

        }

        public Customer getCustomerById(int userId)
        {

            Customer? c = null;

            if (userId > 0)
            {
                c = this._dbConnection.Customers.Where(x => x.customerId == userId).FirstOrDefault();
            }

            return c;
        }
    }
}
