using System;
using Unity;
using Unity.Mvc;

namespace Microsoft.Extensions.DependencyInjection.Specification
{
    public class DependencyInjectionSpecificationTestsImpl : DependencyInjectionSpecificationTests
    {
        protected override IServiceProvider CreateServiceProvider(IServiceCollection serviceCollection)
        {
            var container = new UnityContainer();
            Configuration.Register(serviceCollection, container);
            return container.Resolve<IServiceProvider>();
        }
    }
}