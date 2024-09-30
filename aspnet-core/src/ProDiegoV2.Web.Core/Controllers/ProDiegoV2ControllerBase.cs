using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ProDiegoV2.Controllers
{
    public abstract class ProDiegoV2ControllerBase: AbpController
    {
        protected ProDiegoV2ControllerBase()
        {
            LocalizationSourceName = ProDiegoV2Consts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
