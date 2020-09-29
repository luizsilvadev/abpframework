using Abp.MultiTenancy;
using App.ExemploMvc.Authorization.Users;

namespace App.ExemploMvc.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
