using SalesPortalDL.Entities;
using SalesPortalDL.DataConnection;
public class CustomersBL
{

    private readonly SalesPortalContext _dbConnection;
    public CustomersBL(string connectionString, string databaseVersion)
    {

        this._dbConnection = new SalesPortalContext(connectionString, databaseVersion);

    }

    public Customer getCustomerbyId(int userId)
    {

        Customer? c = null;

        if (userId > 0)
        {
            c = this._dbConnection.Customers.Where(x => x.customerId == userId).FirstOrDefault();
        }

        return c;
    }
}
