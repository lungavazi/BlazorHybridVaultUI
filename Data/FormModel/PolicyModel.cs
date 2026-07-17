
using System.ComponentModel.DataAnnotations;

namespace VaultUI.Data.FormModel
{
    public class PolicyModel
    {
        [Required]
        public string Name { get; set; }
        public long Id { get; set; }
        [Required]
        public string InsuranceType { get; set; }
        [Required]
        public string InsuranceNo { get; set; }
        [Required]
        public DateTime DateOpened { get; set; }
        public HashSet<long> BeneficiaryIds { get; set; } = new HashSet<long>();
    }
}
