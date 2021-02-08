using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Commands.Customers
{
    public class CustomerUpdateCommand : CustomerCommand
    {
        public Guid CustomerId { get; set; }
        
    }
}
