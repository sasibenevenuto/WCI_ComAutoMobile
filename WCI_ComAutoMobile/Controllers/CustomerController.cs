using Application.Handlers.Customers.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Model.Commands.Customers;
using Model.ViewModels.Customers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WCI_ComAutoMobile.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerHandler _customerHanlder;
        public CustomerController(ICustomerHandler customerHanlder)
        {
            _customerHanlder = customerHanlder;
        }

        [HttpGet]
        public async Task<List<CustomerViewModel>> Get()
        {
            return await _customerHanlder.Handler(new CustomerListCommand());
        }

        [HttpPost]
        public async Task Post(CustomerAddCommand command)
        {
            await _customerHanlder.Handler(command);
        }

        [HttpPut]
        public async Task Put(CustomerUpdateCommand command)
        {
            await _customerHanlder.Handler(command);
        }

        [HttpDelete("Delete/{customerId}")]
        public async Task Delete(Guid customerId)
        {
            await _customerHanlder.Handler(customerId);
        }
    }
}
