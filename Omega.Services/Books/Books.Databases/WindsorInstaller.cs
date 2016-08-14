using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Raven.Client;
using Raven.Client.Document;

namespace Books.Databases
{
    public class WindsorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IDocumentStore>().UsingFactoryMethod(() =>
            {
                var dbStore = new DocumentStore()
                {
                    ConnectionStringName = "BooksDatabase",
                }.Initialize(true);
                return dbStore;
            }));
        }
    }
}
