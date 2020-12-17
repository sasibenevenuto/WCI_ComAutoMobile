using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Commands.Customers;
using Application.Handlers.Customers.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.ViewModels.Customers;

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

        [HttpDelete]
        public async Task Get(CustomerDeleteCommand command)
        {
            await _customerHanlder.Handler(command);
        }
    }
}
