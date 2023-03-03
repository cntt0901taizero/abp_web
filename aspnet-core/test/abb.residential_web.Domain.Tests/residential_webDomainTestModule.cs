using abb.residential_web.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace abb.residential_web;

[DependsOn(
    typeof(residential_webEntityFrameworkCoreTestModule)
    )]
public class residential_webDomainTestModule : AbpModule
{

}
