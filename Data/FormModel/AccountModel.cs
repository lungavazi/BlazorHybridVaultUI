using System.ComponentModel.DataAnnotations;

namespace VaultUI.Data.FormModel
{
    public class AccountModel
    {
        [Required]
        public string Name { get; set; }
        public long Id { get; set; }
        public HashSet<long> BeneficiaryIds { get; set; } = new HashSet<long>();
        [Required]
        public string AccountType { get; set; }
        [Required]
        public string AccountNo { get; set; }
        [Required]
        public DateTime DateOpened { get; set; }
    }
}
