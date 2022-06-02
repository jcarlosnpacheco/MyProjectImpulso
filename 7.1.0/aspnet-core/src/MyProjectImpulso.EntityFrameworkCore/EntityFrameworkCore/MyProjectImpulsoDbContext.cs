using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyProjectImpulso.Authorization.Roles;
using MyProjectImpulso.Authorization.Users;
using MyProjectImpulso.MultiTenancy;

namespace MyProjectImpulso.EntityFrameworkCore
{
    public class MyProjectImpulsoDbContext : AbpZeroDbContext<Tenant, Role, User, MyProjectImpulsoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyProjectImpulsoDbContext(DbContextOptions<MyProjectImpulsoDbContext> options)
            : base(options)
        {
        }
    }
}
