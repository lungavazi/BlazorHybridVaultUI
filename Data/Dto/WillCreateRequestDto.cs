using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaultUI.Data.Dto
{
    public class WillCreateRequestDto
    {
        public string Username { get; set; } = string.Empty;
        public string Draft { get; set; } = string.Empty;
        public List<WillBeneficiaries> Beneficiaries { get; set; }
    }
    

    public class WillBeneficiaries
    {
        public long Beneficiaryid { get; set; }
        public decimal Percentage { get; set; }
    }
}
