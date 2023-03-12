using MediatR;
using MediatR.Pipeline;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.TenantManagement;

namespace abb.residential_web;

[DependsOn(
    typeof(residential_webDomainModule),
    typeof(AbpAccountApplicationModule),
    typeof(residential_webApplicationContractsModule),
    typeof(AbpIdentityApplicationModule),
    typeof(AbpPermissionManagementApplicationModule),
    typeof(AbpTenantManagementApplicationModule),
    typeof(AbpFeatureManagementApplicationModule),
    typeof(AbpSettingManagementApplicationModule)
    )]
public class residential_webApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<residential_webApplicationModule>();

        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<residential_webApplicationModule>();
        });

        // Cấu hình MediatR
        context.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestPreProcessorBehavior<,>));
        context.Services.AddMediatR(typeof(residential_webApplicationModule).GetTypeInfo().Assembly);
    }
}
