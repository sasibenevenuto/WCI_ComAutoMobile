using Model.Enums.Customers;
using Model.Models.Companies;
using Model.Models.Customers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.ViewModels.Customers
{
    public class CustomerViewModel
    {
        public Guid CustomerId { get; set; }
        public Guid CompnayId { get; set; }
        public Company Company { get; set; }
        public string TradingName { get; set; }
        public string FantasyName { get; set; }
        public ETypeCustomer TypeCustomer { get; set; }
        public string CpfCnpj { get; set; }
        public string StateRegistration { get; set; }
        public string MunicipalityRegistration { get; set; }
        public string Suframa { get; set; }

        #region .:: Many-To-One ::.        
        public List<CustomerAddress> CustomersAddress { get; set; }
        #endregion

        public static implicit operator CustomerViewModel(Customer model)
        {
            return new CustomerViewModel
            {
                CustomerId = model.CustomerId,
                CompnayId = model.CompnayId,
                Company = model.Company,
                TradingName = model.TradingName,
                TypeCustomer = model.TypeCustomer

            };
        }
    }
}
