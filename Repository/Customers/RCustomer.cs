using Context;
using Microsoft.Extensions.Options;
using Model.Models.Customers;
using Model.Models.General;
using Repository.Customers.Interfaces;
using Repository.General;

namespace Repository.Customers
{
    public  class RCustomer : Repository<Customer>, IRCustomer
    {
        public RCustomer(SolutionContext context) : base(context)
        {
            
        }
    }
}

