using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaultUI.Data.FormModel
{
    public class BeneficiaryModel
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        public long UserId { get; set; }
        [Required]
        public string Relationship { get; set; }
        [Required]
        public string CellPhone { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}
