using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace App.ExemploMvc.Controllers
{
    public abstract class ExemploMvcControllerBase: AbpController
    {
        protected ExemploMvcControllerBase()
        {
            LocalizationSourceName = ExemploMvcConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
