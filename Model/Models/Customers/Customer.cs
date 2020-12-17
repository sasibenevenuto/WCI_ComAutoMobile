using Model.Enums.Customers;
using Model.Models.Companies;
using Model.Models.General;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Models.Customers
{
    [Table("Customer")]
    public class Customer : BaseModel
    {
        public Customer()
        {
        }

        public Customer(string tradingName, int idade)
        {
            CustomerId = Guid.NewGuid();
            TradingName = tradingName;
            Idade = idade;
        }

        [Key]
        public Guid CustomerId { get; set; }

        //[ForeignKey("Company")]
        //public Guid CompnayId { get; set; }
        //public Company Company { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string TradingName { get; set; }

        public int Idade { get; set; }

        //[Column(TypeName = "nvarchar(200)")]
        //public string FantasyName { get; set; }

        //public ETypeCustomer TypeCustomer { get; set; }

        //[Column(TypeName = "nvarchar(20)")]
        //public string CpfCnpj { get; set; }

        //[Column(TypeName = "nvarchar(20)")]
        //public string StateRegistration { get; set; }

        //[Column(TypeName = "nvarchar(20)")]
        //public string MunicipalityRegistration { get; set; }

        //[Column(TypeName = "nvarchar(100)")]
        //public string Suframa { get; set; }

        #region .:: PesonalInformation ::.
       // [ForeignKey("PersonalInformationCreate")]
        //public new int? UserIDCreate { get; set; }
        //public PersonalInformation PersonalInformationCreate { get; set; }
        //[ForeignKey("PersonalInformationUpdate")]
        //public new int? UserIDLastUpdate { get; set; }
        //public PersonalInformation PersonalInformationUpdate { get; set; }
        #endregion

        #region .:: Many-To-One ::.
        //public List<Agenda> Agendas { get; set; }        
        //public List<CustomerAddress> CustomersAddress { get; set; }
        #endregion
    }
}
