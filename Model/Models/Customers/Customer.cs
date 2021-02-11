using Model.Commands.Customers;
using Model.Enums.Customers;
using Model.Models.Common;
using Model.Models.Companies;
using Model.Models.General;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Models.Customers
{
    [Table("CUS_Customer")]
    public class Customer : BaseModel
    {
        [Key]
        public Guid CustomerId { get; set; }

        [ForeignKey("Company")]
        public Guid CompnayId { get; set; }
        public Company Company { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string TradingName { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string FantasyName { get; set; }

        public ETypeCustomer TypeCustomer { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string CpfCnpj { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string StateRegistration { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string MunicipalityRegistration { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Suframa { get; set; }

        #region .:: PesonalInformation ::.
        [ForeignKey("PersonalInformationCreate")]
        public override int UserIDCreate { get; set; }
        public PersonalInformation PersonalInformationCreate { get; set; }
        [ForeignKey("PersonalInformationUpdate")]
        public override int UserIDLastUpdate { get; set; }
        public PersonalInformation PersonalInformationUpdate { get; set; }
        #endregion

        #region .:: Many-To-One ::.
        //public List<Agenda> Agendas { get; set; }        
        public List<CustomerAddress> CustomersAddress { get; set; }
        #endregion

        public Customer ParseAdd(CustomerAddCommand command)
        {
            return Parse(command);

        }

        public Customer ParseUpdate(CustomerUpdateCommand command)
        {
            var customer = Parse(command);
            customer.CustomerId = command.CustomerId;

            return customer;
        }

        public Customer Parse(CustomerCommand command)
        {
            return new Customer()
            {
                TradingName = command.TradingName
            };
        }
    }
}
