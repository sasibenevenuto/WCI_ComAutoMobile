using Model.Models.Common;
using Model.Models.General;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [ForeignKey("Claim")]
        public int ClaimId { get; set; }
        public Claim Claim { get; set; }

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
