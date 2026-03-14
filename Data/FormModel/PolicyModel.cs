using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please select a beneficiary.")]
        public long BeneficiaryId { get; set; }
    }
}
