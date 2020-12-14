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
        [Column(TypeName = "nvarchar(200)")]
        public string Description { get; set; }
        public ETypeFunctionClaim TypeFunctionClaim { get; set; }

        #region .:: PesonalInformation ::.
        [ForeignKey("PersonalInformationUser")]
        public override int UserIDCreate { get; set; }
        public PersonalInformation PersonalInformationUser { get; set; }
        [ForeignKey("PersonalInformationUpdate")]
        public override int UserIDLastUpdate { get; set; }
        public PersonalInformation PersonalInformationUpdate { get; set; }
        #endregion
    }
}
