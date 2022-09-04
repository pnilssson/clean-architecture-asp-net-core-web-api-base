using AspNetCoreWebApiBase.Application.Interfaces;
using AspNetCoreWebApiBase.Application.Models;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreWebApiBase.Infrastructure.Persistence;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

    }

    public DbSet<DummyEntityClass> DummyClass { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
    }

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return await base.SaveChangesAsync(cancellationToken);
    }
}
