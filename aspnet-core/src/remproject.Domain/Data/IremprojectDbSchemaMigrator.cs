using System.Threading.Tasks;

namespace remproject.Data;

public interface IremprojectDbSchemaMigrator
{
    Task MigrateAsync();
}
