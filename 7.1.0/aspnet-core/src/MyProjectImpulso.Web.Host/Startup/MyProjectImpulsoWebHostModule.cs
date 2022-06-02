using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyProjectImpulso.Configuration;

namespace MyProjectImpulso.Web.Host.Startup
{
    [DependsOn(
       typeof(MyProjectImpulsoWebCoreModule))]
    public class MyProjectImpulsoWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MyProjectImpulsoWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyProjectImpulsoWebHostModule).GetAssembly());
        }
    }
}
