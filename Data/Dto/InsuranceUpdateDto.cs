using System;
using System.Collections.Generic;

namespace VaultUI.Data.Dto
{
    public class InsuranceUpdateDto
    {
        public string Name { get; set; }
        public List<long> BeneficiaryIds { get; set; } = new List<long>();
        public string InsuranceType { get; set; }
        public string InsuranceNo { get; set; }
        public DateTime DateOpened { get; set; }
    }
}
