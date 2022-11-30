using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace remproject.Data;

/* This is used if database provider does't define
 * IremprojectDbSchemaMigrator implementation.
 */
public class NullremprojectDbSchemaMigrator : IremprojectDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
