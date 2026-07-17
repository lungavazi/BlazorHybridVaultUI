using System;
using System.Collections.Generic;

namespace VaultUI.Data.Dto
{
    public class AccountUpdateDto
    {
        public string Name { get; set; }
        public List<long> BeneficiaryIds { get; set; } = new List<long>();
        public string AccountType { get; set; }
        public string AccountNo { get; set; }
        public DateTime DateOpened { get; set; }
    }
}
