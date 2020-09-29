using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using App.ExemploMvc.Configuration;

namespace App.ExemploMvc.Web.Startup
{
    [DependsOn(typeof(ExemploMvcWebCoreModule))]
    public class ExemploMvcWebMvcModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ExemploMvcWebMvcModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<ExemploMvcNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ExemploMvcWebMvcModule).GetAssembly());
        }
    }
}
