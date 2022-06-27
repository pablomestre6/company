using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using company.Authorization.Roles;
using company.Authorization.Users;
using company.MultiTenancy;

namespace company.EntityFrameworkCore
{
    public class companyDbContext : AbpZeroDbContext<Tenant, Role, User, companyDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public companyDbContext(DbContextOptions<companyDbContext> options)
            : base(options)
        {
        }
    }
}
