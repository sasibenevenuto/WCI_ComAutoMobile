using Model.Models.General;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Models.Customers
{
    [Table("CustomerAddress")]
    public class CustomerAddress : BaseModel
    {
        [Key]
        public long CustomerAddressId { get; set; }

        [ForeignKey("Customer")]
        public long CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Column("nvarchar(20)")]
        public string CellPhone { get; set; }

        [Column("nvarchar(200)")]
        public string PhoneNumbers { get; set; }

        [Column("nvarchar(20)")]
        public string PostalCode { get; set; }

        [Column("nvarchar(250)")]
        public string Address { get; set; }

        [Column("nvarchar(200)")]
        public string AddressNumber { get; set; }

        [Column("nvarchar(400)")]
        public string AddressComplement { get; set; }

        [Column("nvarchar(200)")]
        public string Neighborhood { get; set; }

        [ForeignKey("City")]
        public int CityId { get; set; }
        public City City { get; set; }
    }
}
