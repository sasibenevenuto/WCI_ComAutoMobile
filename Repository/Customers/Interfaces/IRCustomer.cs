using Model.Models.Customers;
using Model.ViewModels.Customers;
using Repository.General.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Customers.Interfaces
{
    public interface IRCustomer : IRepository<Customer>
    {
        Task<List<CustomerViewModel>> GetListCustomerAsync();
        Task AddCustomerAsync(Customer customer);
        Task UpdateCustomerAsync(Customer customer);
        Task DeleteCustomerAsync(Guid customerId);
    }
}
