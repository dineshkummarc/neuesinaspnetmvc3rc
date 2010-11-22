using System.Web.Mvc;
using StructureMap.Configuration.DSL;

namespace NewInMVC3.Infrastructure.Registration
{
    public class AspNetMvc3Registry : Registry
    {
        public AspNetMvc3Registry()
        {
            Scan(x =>
            {
                x.AssembliesFromApplicationBaseDirectory();
                x.AddAllTypesOf<ModelValidatorProvider>();
                x.AddAllTypesOf<ModelMetadataProvider>();
                x.AddAllTypesOf<ValueProviderFactory>();
                x.AddAllTypesOf<IModelBinderProvider>();
                x.AddAllTypesOf<IControllerActivator>();
                x.AddAllTypesOf<IViewPageActivator>();
                x.AddAllTypesOf<IFilterProvider>();
                x.With(new ControllerRegistryConvention());
            });

        }
    }
}