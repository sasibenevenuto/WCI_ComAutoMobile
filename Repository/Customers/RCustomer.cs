using Context;
using Microsoft.Extensions.Options;
using Model.Models.Customers;
using Model.Models.General;
using Model.ViewModels.Customers;
using Repository.Customers.Interfaces;
using Repository.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Customers
{
    public class RCustomer : Repository<Customer>, IRCustomer
    {
        public RCustomer(SolutionContext context) : base(context)
        {

        }

        public async Task AddCustomerAsync(Customer customer)
        {
            await AddAsync(customer, @"
                    INSERT INTO [dbo].[Customer]
                               ([CustomerId]
                               ,[TradingName]
                               ,[Idade]
                               ,[UserIDCreate]
                               ,[UserIDLastUpdate]
                               ,[Active]
                               ,[CreateDate]
                               ,[ModifieldDate])
                         VALUES
                               (@CustomerId
                               ,@TradingName
                               ,@Idade
                               ,NULL
                               ,NULL
                               ,1
                               ,GETDATE()
                               ,GETDATE())");
        }

        public async Task DeleteCustomerAsync(Guid customerId)
        {
            await DeleteAsync(new Customer() { CustomerId = customerId }, $@"DELETE FROM [dbo].[Customer] WHERE [CustomerId] = @CustomerId");
        }

        public async Task<List<CustomerViewModel>> GetListCustomerAsync()
        {
            return (await GetListAsync(new Customer(), "SELECT * FROM State")).Select(x => (CustomerViewModel)x).ToList();
        }

        public async Task UpdateCustomerAsync(Customer customer)
        {
            await UpdateAsync(customer, $@"
                UPDATE [dbo].[Customer]
                   SET 
                       [TradingName] = @TradingName
                      ,[Idade] = @Idade            
                      ,[ModifieldDate] = GETDATE()
                 WHERE [CustomerId]  = @CustomerId
                ");
        }
    }
}


