using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using remproject.Data;
using Volo.Abp.DependencyInjection;

namespace remproject.EntityFrameworkCore;

public class EntityFrameworkCoreremprojectDbSchemaMigrator
    : IremprojectDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreremprojectDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the remprojectDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<remprojectDbContext>()
            .Database
            .MigrateAsync();
    }
}
