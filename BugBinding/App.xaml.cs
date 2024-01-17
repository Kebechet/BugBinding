using Purchases = Maui.RevenueCat.iOS.RCPurchases;

namespace BugBinding
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            var publicApiKey = "appl_IbYjYDwWLoqUZXxFXrCCyJKLPZc";

            var result = Purchases.ConfigureWithAPIKey(publicApiKey);
            if(result is null)
            {
                throw new Exception("Binding doesnt work correctly");
            }
        }
    }
}
