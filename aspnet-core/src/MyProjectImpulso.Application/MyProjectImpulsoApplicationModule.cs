using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyProjectImpulso.Authorization;

namespace MyProjectImpulso
{
    [DependsOn(
        typeof(MyProjectImpulsoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyProjectImpulsoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyProjectImpulsoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MyProjectImpulsoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
