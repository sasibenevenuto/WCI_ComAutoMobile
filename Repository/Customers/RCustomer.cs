using Microsoft.Extensions.Options;
using Model.Models.Customers;
using Model.Models.General;
using Repository.Customers.Interfaces;
using Repository.General;

namespace Repository.Customers
{
    public  class RCustomer : Repository<Customer>, IRCustomer
    {
        public RCustomer(IOptions<Settings> options)
        {
            _settings = options.Value;
        }
    }
}

