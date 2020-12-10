using Model.Models.General;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Models.Identity
{
    [Table("Users_x_Claims")]
    public class Users_x_Claims : BaseModel
    {
        [Key]
        public int Users_x_ClaimsId { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

        public int ClaimId { get; set; }
        public Claim Claim { get; set; }

    }
}
