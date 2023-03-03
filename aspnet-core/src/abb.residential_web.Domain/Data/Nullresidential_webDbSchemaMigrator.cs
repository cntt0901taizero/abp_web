using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace abb.residential_web.Data;

/* This is used if database provider does't define
 * Iresidential_webDbSchemaMigrator implementation.
 */
public class Nullresidential_webDbSchemaMigrator : Iresidential_webDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
