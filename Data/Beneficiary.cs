using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaultUI.Data
{
    public class Beneficiary
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long UserId { get; set; }
        public string Relationship { get; set; }
        public string CellNo { get; set; }
        public string SecondaryTelephone { get; set; }
        public string Email { get; set; }
        public string SecondaryEmail { get; set; }
        public string Address { get; set; }
        public string DateOfBirth { get; set; }
    }
}
