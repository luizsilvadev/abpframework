using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace App.ExemploMvc.Web.Views
{
    public abstract class ExemploMvcRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ExemploMvcRazorPage()
        {
            LocalizationSourceName = ExemploMvcConsts.LocalizationSourceName;
        }
    }
}
