using System.Globalization;
using System.Resources;
using System.Windows;

namespace LocalizationTest
{
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var resourceManager = new ResourceManager(GetType());

            var window = new Window
            {
                Title = resourceManager.GetString("ResourceKey", CultureInfo.GetCultureInfo("de"))
            };

            window.Show();
        }
    }
}