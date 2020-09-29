using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using App.ExemploMvc.Configuration;

namespace App.ExemploMvc.Web.Host.Startup
{
    [DependsOn(
       typeof(ExemploMvcWebCoreModule))]
    public class ExemploMvcWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ExemploMvcWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ExemploMvcWebHostModule).GetAssembly());
        }
    }
}
