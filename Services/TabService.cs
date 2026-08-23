using System;

namespace VaultUI.Services
{
    public class TabService
    {
        public event Action<int>? OnTabRequested;

        public void OpenTab(int index) => OnTabRequested?.Invoke(index);
    }
}