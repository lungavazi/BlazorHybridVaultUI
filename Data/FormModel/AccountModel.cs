using System.ComponentModel.DataAnnotations;

namespace VaultUI.Data.FormModel
{
    public class AccountModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public long BeneficiaryId { get; set; }
        [Required]
        public string AccountType { get; set; }
        [Required]
        public string AccountNo { get; set; }
        [Required]
        public DateTime DateOpened { get; set; }
    }
}
