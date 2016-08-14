using Books.Databases.BooksDb;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Books.Databases
{
    public class WindsorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IBooksDbFactory>().ImplementedBy<BooksDbFactory>());
        }
    }
}
