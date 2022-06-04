using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyProjectImpulso.EntityFrameworkCore;
using MyProjectImpulso.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace MyProjectImpulso.Web.Tests
{
    [DependsOn(
        typeof(MyProjectImpulsoWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MyProjectImpulsoWebTestModule : AbpModule
    {
        public MyProjectImpulsoWebTestModule(MyProjectImpulsoEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyProjectImpulsoWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MyProjectImpulsoWebMvcModule).Assembly);
        }
    }
}