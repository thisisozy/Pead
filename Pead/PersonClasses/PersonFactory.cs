using Autofac;

namespace Pead.PersonClasses
{
    public class PersonFactory
    {
        public static Person CreatePerson(string _loggerType, string _firstname, string _lastname)
        {
            ContainerBuilder containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<Person>();

            var build = containerBuilder.Build();

            using var scope = build.BeginLifetimeScope();
                return scope.Resolve<Person>(
                    new NamedParameter("firstname", _firstname),
                    new NamedParameter("lastname", _lastname));
        }
    }
}