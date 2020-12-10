using Model.Models.General;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Models.Companies
{
    [Table("Account")]
    public class Account : BaseModel
    {
        [Key]
        public Guid AccountId { get; set; }


    }
}
