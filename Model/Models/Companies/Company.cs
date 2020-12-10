using Model.Models.General;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Models.Companies
{
    [Table("Company")]
    public class Company : BaseModel
    {
        [Key]
        public Guid CompanyId { get; set; }
    }
}
