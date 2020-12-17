using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Commands.Customers
{
    public class CustomerUpdateCommand
    {
        public Guid CustomerId { get; set; }        
        public string TradingName { get; set; }
        public int Idade { get; set; }
    }
}
