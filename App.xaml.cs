using prism_hello_world.Views;
using System.Windows;

namespace prism_hello_world
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Bootstrapper bootstrapper = new();
            bootstrapper.Run();
        }
    }
}
