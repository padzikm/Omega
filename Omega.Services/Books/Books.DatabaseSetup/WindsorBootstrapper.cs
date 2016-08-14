using Castle.Windsor;
using Castle.Windsor.Installer;

namespace Books.DatabaseSetup
{
    class WindsorBootstrapper
    {
        public static IWindsorContainer Bootstrapp()
        {
            var container = new WindsorContainer();
            container.Install(FromAssembly.InThisApplication());
            return container;
        }
    }
}
