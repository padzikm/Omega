using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace Books.Service
{
    class WindsorBootstrapper
    {
        public static IWindsorContainer Bootstrapp()
        {
            var container = new WindsorContainer();
            container.Install(FromAssembly.This());
            return container;
        }
    }
}
