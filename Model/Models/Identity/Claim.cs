using Model.Enums.Identity;
using Model.Models.General;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model.Models.Identity
{
    [Table("Claim")]
    public class Claim : BaseModel
    {
        [Key]
        public int ClaimId { get; set; }
        public string Description { get; set; }
        public ETypeFunctionClaim TypeFunctionClaim { get; set; }
    }
}
