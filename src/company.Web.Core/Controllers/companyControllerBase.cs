using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace company.Controllers
{
    public abstract class companyControllerBase: AbpController
    {
        protected companyControllerBase()
        {
            LocalizationSourceName = companyConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
