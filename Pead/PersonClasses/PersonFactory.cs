using Autofac;
using Pead.LoggerClasses;

namespace Pead.PersonClasses
{
    public class PersonFactory
    {
        public static Person CreatePerson(string _loggerType, string _firstname, string _lastname)
        {
            ContainerBuilder containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<FileLogger>().Named<ILogger>("file");
            containerBuilder.RegisterType<ConsoleLogger>().Named<ILogger>("console");
            containerBuilder.RegisterType<Person>()
                .WithParameter(
                    (pi, ctx) => pi.ParameterType == typeof(ILogger),
                    (pi, ctx) => ctx.ResolveNamed<ILogger>(_loggerType));

            var build = containerBuilder.Build();

            using var scope = build.BeginLifetimeScope();
                return scope.Resolve<Person>(
                    new NamedParameter("firstname", _firstname),
                    new NamedParameter("lastname", _lastname));
        }
    }
}