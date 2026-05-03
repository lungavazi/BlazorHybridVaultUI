
namespace VaultUI.Services
{
    public class LoadingService
    {
        public event Action OnChange;
        private void NotifyChange() => OnChange?.Invoke();

        bool isLoading;

        public bool IsLoading
        {
            get => isLoading;
            set
            {
                if (isLoading != value)
                {
                    isLoading = value;
                    NotifyChange();
                }
            }
        }
    }
}
