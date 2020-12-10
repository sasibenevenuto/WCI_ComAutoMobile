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
    }
}
