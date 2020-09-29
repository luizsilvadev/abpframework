using Abp.AutoMapper;
using App.ExemploMvc.Authentication.External;

namespace App.ExemploMvc.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
