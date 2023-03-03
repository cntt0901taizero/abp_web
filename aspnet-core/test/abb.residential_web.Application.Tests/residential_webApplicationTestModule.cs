using Volo.Abp.Modularity;

namespace abb.residential_web;

[DependsOn(
    typeof(residential_webApplicationModule),
    typeof(residential_webDomainTestModule)
    )]
public class residential_webApplicationTestModule : AbpModule
{

}
