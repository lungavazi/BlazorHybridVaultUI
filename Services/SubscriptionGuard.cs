using MudBlazor;

namespace VaultUI.Services
{
    public class SubscriptionGuard
    {
        private readonly AuthService _authService;
        private readonly ISnackbar _snackbar;
        private readonly TabService _tabService;

        public SubscriptionGuard(AuthService authService, ISnackbar snackbar, TabService tabService)
        {
            _authService = authService;
            _snackbar = snackbar;
            _tabService = tabService;
        }

        /// <summary>
        /// Returns true if the user is subscribed. Otherwise shows a snackbar and optionally navigates to subscription.
        /// </summary>
        public bool CanAccess(bool navigateToSubscription = false)
        {
            if (_authService.IsSubscribed)
                return true;

            _snackbar.Add("This feature requires an active subscription.", Severity.Warning);

            if (navigateToSubscription)
                _tabService.OpenTab(5);

            return false;
        }

        /// <summary>
        /// Async version for use with async methods
        /// </summary>
        public Task<bool> CanAccessAsync(bool navigateToSubscription = false)
        {
            return Task.FromResult(CanAccess(navigateToSubscription));
        }
    }
}