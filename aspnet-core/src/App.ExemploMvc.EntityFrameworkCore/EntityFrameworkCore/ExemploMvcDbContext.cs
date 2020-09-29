using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using App.ExemploMvc.Authorization.Roles;
using App.ExemploMvc.Authorization.Users;
using App.ExemploMvc.MultiTenancy;

namespace App.ExemploMvc.EntityFrameworkCore
{
    public class ExemploMvcDbContext : AbpZeroDbContext<Tenant, Role, User, ExemploMvcDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ExemploMvcDbContext(DbContextOptions<ExemploMvcDbContext> options)
            : base(options)
        {
        }
    }
}
