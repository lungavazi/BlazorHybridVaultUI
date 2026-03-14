
namespace VaultUI.Services
{
    public class LoadingService
    {
        public event Action OnChange;

        bool isLoading;

        public bool IsLoading
        {
            get => isLoading;
            set
            {
                isLoading = value;
                OnChange?.Invoke();
            }
        }
    }
}
