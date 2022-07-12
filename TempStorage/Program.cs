namespace TempStorage
{
    using Autofac;
    using System;
    using System.Reflection;
    using TempStorage.Services;

    internal class Program
    {
        static void Main(string[] args)
        {
            ContainerBuilder builder = new();
            builder.RegisterAssemblyModules(
                Assembly.GetExecutingAssembly());


            using IContainer container = builder.Build();

            ILowLevelStorage lowLevelStorage = container.Resolve<ILowLevelStorage>();

            lowLevelStorage.Put(
                "path1",
                "content1");
        }
    }
}
