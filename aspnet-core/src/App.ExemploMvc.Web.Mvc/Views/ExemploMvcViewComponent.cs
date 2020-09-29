using Abp.AspNetCore.Mvc.ViewComponents;

namespace App.ExemploMvc.Web.Views
{
    public abstract class ExemploMvcViewComponent : AbpViewComponent
    {
        protected ExemploMvcViewComponent()
        {
            LocalizationSourceName = ExemploMvcConsts.LocalizationSourceName;
        }
    }
}
