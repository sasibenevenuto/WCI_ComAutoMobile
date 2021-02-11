using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models.Identity
{
    [Table("IDE_AspNetUsers")]
    public class User : IdentityUser
    {        
        public override string Id { get; set; }

        [ForeignKey("Profile")]
        public int? ProfileId { get; set; }
        public Profile Profile { get; set; }
    }
}
