using System;
using System.Collections.Generic;

namespace VaultUI.Data.Dto
{
    public class AccountCreateDto
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public List<long> BeneficiaryIds { get; set; } = new List<long>();
        public string AccountType { get; set; }
        public string AccountNo { get; set; }
        public DateTime DateOpened { get; set; }
    }
}
