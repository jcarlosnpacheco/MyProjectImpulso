using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyProjectImpulso.Controllers
{
    public abstract class MyProjectImpulsoControllerBase: AbpController
    {
        protected MyProjectImpulsoControllerBase()
        {
            LocalizationSourceName = MyProjectImpulsoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
