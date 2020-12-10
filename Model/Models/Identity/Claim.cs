using Model.Models.General;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Models.Identity
{
    [Table("Claim")]
    public class Claim : BaseModel
    {
        [Key]
        public int ClaimId { get; set; }
    }
}
