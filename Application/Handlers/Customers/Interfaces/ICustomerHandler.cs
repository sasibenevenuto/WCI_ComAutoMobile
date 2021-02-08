using Model.Commands.Customers;
using Model.ViewModels.Customers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Handlers.Customers.Interfaces
{
    public interface ICustomerHandler
    {
        Task<List<CustomerViewModel>> Handler(CustomerListCommand command);
        Task Handler(CustomerAddCommand command);
        Task Handler(CustomerUpdateCommand command);
        Task Handler(Guid customerId);
    }
}
