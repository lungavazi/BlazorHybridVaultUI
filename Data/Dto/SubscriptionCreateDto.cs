namespace VaultUI.Data.Dto
{
    using System;
    using VaultUI.Helpers;

    public class SubscriptionCreateDto
    {
        public string UserName { get; set; } = string.Empty;
        public CycleType Cycle { get; set; }
        public decimal Amount { get; set; }
        public DateTime SubscribedAt { get; set; }
    }
}