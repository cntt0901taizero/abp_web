using System.Threading.Tasks;

namespace abb.residential_web.Data;

public interface Iresidential_webDbSchemaMigrator
{
    Task MigrateAsync();
}
