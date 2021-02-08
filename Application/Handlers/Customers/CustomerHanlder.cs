using Application.Handlers.Customers.Interfaces;
using Model.Commands.Customers;
using Model.Models.Customers;
using Model.ViewModels.Customers;
using Repository.Customers.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Handlers.Customers
{
    public class CustomerHanlder : ICustomerHandler
    {
        private readonly IRCustomer _rCustomer;
        public CustomerHanlder(IRCustomer rCustomer)
        {
            _rCustomer = rCustomer;
        }

        public async Task<List<CustomerViewModel>> Handler(CustomerListCommand command)
        {
            try
            {
                return await _rCustomer.GetListCustomerAsync();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Handler(CustomerAddCommand command)
        {
            try
            {
                await _rCustomer.AddCustomerAsync(new Customer().ParseAdd(command));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Handler(CustomerUpdateCommand command)
        {
            try
            {
                await _rCustomer.UpdateCustomerAsync(new Customer().ParseUpdate(command));
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Handler(Guid customerId)
        {
            try
            {
                await _rCustomer.DeleteCustomerAsync(customerId);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
