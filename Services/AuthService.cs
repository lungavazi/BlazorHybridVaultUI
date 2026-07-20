using VaultUI.Data.Dto;
using VaultUI.Helpers;

namespace VaultUI.Services
{
    public class AuthService
    {
        private LoginResponseDto? _currentUser;

        // Subscription state
        private CycleType? _subscribedCycle;
        private DateTime? _subscribedAt;
        private bool? _active;
        public bool IsAuthenticated => _currentUser != null && _currentUser.ExpiresAt > DateTime.UtcNow;

        public string? Token => _currentUser?.Token;
        public string? Email => _currentUser?.Email;
        public string? FullName => _currentUser?.FullName;

        public CycleType? SubscribedCycle => _subscribedCycle;
        public DateTime? SubscribedAt => _subscribedAt;
        public bool IsSubscribed => _subscribedCycle.HasValue;

        public event Action? OnAuthStateChanged;
        public event Action? OnSubscriptionChanged;

        public void SetUser(LoginResponseDto user)
        {
            _currentUser = user;
            OnAuthStateChanged?.Invoke();
        }

        public void Logout()
        {
            _currentUser = null;
            // Clear subscription on logout (session-scoped)
            _subscribedCycle = null;
            _subscribedAt = null;
            _active = false;
            OnAuthStateChanged?.Invoke();
            OnSubscriptionChanged?.Invoke();
        }

        public void Subscribe(UserInfoDto userSubscrptionData)
        {
            // Trial means no paid subscription; treat as unsubscribe
            //if (cycle == CycleType.Trial)
            //{
            //    Unsubscribe();
            //    return;
            //}

            _subscribedCycle = userSubscrptionData.SubscribedPeriod;
            _subscribedAt = userSubscrptionData.SubscribedAt;
            _active = userSubscrptionData.IsSubscribed;
            OnSubscriptionChanged?.Invoke();
        }

        public void Unsubscribe()
        {
            _subscribedCycle = null;
            _subscribedAt = null;
            OnSubscriptionChanged?.Invoke();
        }

        public class UserSubscrptionData
        {
        }
    }
}
