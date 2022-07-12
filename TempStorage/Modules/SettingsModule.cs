namespace TempStorage.Modules
{
    using Autofac;
    using TempStorage.Models;

    public class SettingsModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterInstance(
                    new AWSSettings(
                        "Bucket 1",
                        "Temp Bucket 1"));
        }
    }
}