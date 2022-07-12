namespace TempStorage.Modules
{
    using Autofac;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TempStorage.Services;

    public class StorageModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<LowLevelStorage>()
                .AsImplementedInterfaces();
        }
    }
}
