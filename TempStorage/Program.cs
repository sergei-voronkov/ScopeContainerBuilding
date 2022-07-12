namespace TempStorage
{
    using Autofac;
    using System.Reflection;
    using TempStorage.Services;

    internal class Program
    {
        private static void Main(string[] args)
        {
            ContainerBuilder builder = new();
            builder.RegisterAssemblyModules(
                Assembly.GetExecutingAssembly());

            using IContainer container = builder.Build();

            IStorage storage = container.Resolve<IStorage>();

            storage.Put(
                "path1",
                "content1");

            ITempStorage tempStorage = container.Resolve<ITempStorage>();

            tempStorage.Put(
                "path1",
                "content1");
        }
    }
}