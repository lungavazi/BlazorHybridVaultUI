using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaultUI.Data.Dto
{
    public class BeneficiaryCreateDto
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Relationship { get; set; }
        public string CellNo { get; set; }
        public string SecondaryTelephone { get; set; }
        public string Email { get; set; }
        public string secondaryEmail { get; set; }
        public string Address { get; set; }
        public string DateOfBirth { get; set; }
    }
}
