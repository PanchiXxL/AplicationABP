using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Example.Authorization.Roles;
using Example.Authorization.Users;
using Example.MultiTenancy;

namespace Example.EntityFrameworkCore
{
    public class ExampleDbContext : AbpZeroDbContext<Tenant, Role, User, ExampleDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ExampleDbContext(DbContextOptions<ExampleDbContext> options)
            : base(options)
        {
        }
    }
}
