namespace TempStorage.Modules
{
    using Autofac;
    using Autofac.Core;
    using Autofac.Core.Resolving.Pipeline;
    using TempStorage.Models;
    using TempStorage.Services;

    public class StorageModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder
                .RegisterType<LowLevelStorage>()
                .AsImplementedInterfaces();

            builder
                .RegisterType<Storage>()
                .As<IStorage>();

            builder
                .RegisterType<Storage>()
                .ConfigurePipeline(
                    resolvePipelineBuilder =>
                    {
                        resolvePipelineBuilder.Use(
                            PipelinePhase.RegistrationPipelineStart,
                            (resolveRequestContext, next) =>
                            {
                                AWSSettings aws1 = resolveRequestContext.Resolve<AWSSettings>();

                                ILifetimeScope s1 = resolveRequestContext.ActivationScope.BeginLifetimeScope(b =>
                                {
                                    // b.RegisterInstance(
                                    //     new AWSSettings(
                                    //         "Bucket 2",
                                    //         "Temp Bucket 2"));

                                    b.RegisterInstance(
                                        aws1 with
                                        {
                                            Bucket = aws1.TempBucket
                                        });
                                });

                                resolveRequestContext.ChangeScope((ISharingLifetimeScope)s1);
                                next(resolveRequestContext);
                            });
                    })
                .As<ITempStorage>();
        }
    }
}