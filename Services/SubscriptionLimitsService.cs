namespace VaultUI.Services
{
    public class SubscriptionLimitsService
    {
        private readonly AuthService _authService;

        public SubscriptionLimitsService(AuthService authService)
        {
            _authService = authService;
        }

        // Subscription limit constants
        private const int FreeTrialBeneficiaryLimit = 1;
        private const int FreeTrialPolicyLimit = 1;
        private const int FreeTrialAccountLimit = 1;
        private const int FreeTrialWillLimit = 1;

        /// <summary>
        /// Get the maximum number of items allowed for a given feature.
        /// </summary>
        public int GetLimit(string featureName) => featureName.ToLower() switch
        {
            "beneficiaries" => _authService.IsSubscribed ? int.MaxValue : FreeTrialBeneficiaryLimit,
            "policies" => _authService.IsSubscribed ? int.MaxValue : FreeTrialPolicyLimit,
            "accounts" => _authService.IsSubscribed ? int.MaxValue : FreeTrialAccountLimit,
            "wills" => _authService.IsSubscribed ? int.MaxValue : FreeTrialWillLimit,
            _ => 0
        };

        /// <summary>
        /// Check if user can add more items. Returns true if under limit.
        /// </summary>
        public bool CanAddMore(string featureName, int currentCount)
        {
            if (_authService.IsSubscribed)
                return true;

            int limit = GetLimit(featureName);
            return currentCount < limit;
        }

        /// <summary>
        /// Get remaining slots for a feature (for display purposes).
        /// </summary>
        public int GetRemainingSlots(string featureName, int currentCount)
        {
            int limit = GetLimit(featureName);
            return limit == int.MaxValue ? int.MaxValue : Math.Max(0, limit - currentCount);
        }

        /// <summary>
        /// Get a user-friendly message for why they can't add more items.
        /// </summary>
        public string GetUpgradeMessage(string featureName)
        {
            return $"You've reached the limit for {featureName}. Upgrade to add unlimited {featureName.ToLower()}.";
        }
    }
}