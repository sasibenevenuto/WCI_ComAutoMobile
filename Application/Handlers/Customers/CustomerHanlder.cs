using Application.Commands.Customers;
using Application.Handlers.Customers.Interfaces;
using Model.Models.Customers;
using Model.ViewModels.Customers;
using Repository.Customers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                return new List<CustomerViewModel>((await _rCustomer.GetListAsync(new Customer(), "SELECT * FROM State")).Select(x => (CustomerViewModel)x));
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
                await _rCustomer.AddAsync(new Customer(), @"INSERT INTO [dbo].[Customer]
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
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Handler(CustomerUpdateCommand command)
        {
            try
            {
                await _rCustomer.UpdateAsync(new Customer() { CustomerId = command.CustomerId, TradingName = command.TradingName, Idade = command.Idade }, $@"UPDATE [dbo].[Customer]
   SET 
       [TradingName] = @TradingName
      ,[Idade] = @Idade            
      ,[ModifieldDate] = GETDATE()
 WHERE [CustomerId]  = @CustomerId
");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task Handler(CustomerDeleteCommand command)
        {
            try
            {
                await _rCustomer.DeleteAsync(new Customer() { CustomerId = command.CustomerId }, $@"DELETE FROM [dbo].[Customer] WHERE [CustomerId] = @CustomerId");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
