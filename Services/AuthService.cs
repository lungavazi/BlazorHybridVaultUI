using VaultUI.Data.Dto;

namespace VaultUI.Services
{
    public class AuthService
    {
        private LoginResponseDto? _currentUser;

        public bool IsAuthenticated => _currentUser != null && _currentUser.ExpiresAt > DateTime.UtcNow;

        public string? Token => _currentUser?.Token;
        public string? Email => _currentUser?.Email;
        public string? FullName => _currentUser?.FullName;

        public event Action? OnAuthStateChanged;

        public void SetUser(LoginResponseDto user)
        {
            _currentUser = user;
            OnAuthStateChanged?.Invoke();
        }

        public void Logout()
        {
            _currentUser = null;
            OnAuthStateChanged?.Invoke();
        }
    }
}
