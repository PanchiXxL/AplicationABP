using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Example.Controllers
{
    public abstract class ExampleControllerBase: AbpController
    {
        protected ExampleControllerBase()
        {
            LocalizationSourceName = ExampleConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
