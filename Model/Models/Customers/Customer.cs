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
        [Key]
        public long CustomerId { get; set; }

        [ForeignKey("Company")]
        public Guid CompnayId { get; set; }
        public Company Company { get; set; }

        [Column("nvarchar(200)")]
        public string TradingName { get; set; }

        [Column("nvarchar(200)")]
        public string FantasyName { get; set; }

        public ETypeCustomer TypeCustomer { get; set; }

        [Column("nvarchar(20)")]
        public string CpfCnpj { get; set; }

        [Column("nvarchar(20)")]
        public string StateRegistration { get; set; }

        [Column("nvarchar(20)")]
        public string MunicipalityRegistration { get; set; }

        [Column("nvarchar(100)")]
        public string Suframa { get; set; }



        #region .:: PesonalInformation ::.
        [ScaffoldColumn(false), ForeignKey("PersonalInformationUser")]
        public override int UserIDCreate { get; set; }
        [ScaffoldColumn(false)]
        public PersonalInformation PersonalInformationUser { get; set; }
        [ScaffoldColumn(false), ForeignKey("PersonalInformationUpdate")]
        public override int UserIDLastUpdate { get; set; }
        [ScaffoldColumn(false)]
        public PersonalInformation PersonalInformationUpdate { get; set; }
        #endregion

        #region .:: Many-To-One ::.
        //public List<Agenda> Agendas { get; set; }        
        public List<CustomerAddress> CustomersAddress { get; set; }
        #endregion
    }
}
