namespace ScopeContainerBuilding
{
    using Autofac;
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            ContainerBuilder builder = new();
            builder.RegisterType<Store>();
            builder.RegisterType<Recognizer>();
            IContainer container = builder.Build();

            //Recognizer recognizer = container.Resolve<Recognizer>();

            using ILifetimeScope scope = container.BeginLifetimeScope(
                builder =>
                {
                    builder.Register<Store>(context => new Store("Local"));
                });

            Recognizer recognizer = scope.Resolve<Recognizer>();

            recognizer.Recognize();
        }
    }
}
