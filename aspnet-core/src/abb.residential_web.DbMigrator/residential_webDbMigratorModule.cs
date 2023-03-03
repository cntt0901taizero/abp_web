using abb.residential_web.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace abb.residential_web.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(residential_webEntityFrameworkCoreModule),
    typeof(residential_webApplicationContractsModule)
    )]
public class residential_webDbMigratorModule : AbpModule
{

}
