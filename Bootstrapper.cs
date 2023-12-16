using Prism.Ioc;
using Prism.Unity;
using System.Windows;

namespace prism_hello_world.Views
{
    class Bootstrapper : PrismBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Empty.
        }
    }
}
