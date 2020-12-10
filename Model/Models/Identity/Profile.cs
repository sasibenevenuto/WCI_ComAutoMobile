using Model.Models.General;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Models.Identity
{
    [Table("Profile")]
    public class Profile : BaseModel
    {
        [Key]
        public int ProfileId { get; set; }

        [Column("nvarchar(200)")]
        public string Description { get; set; }
    }
}
