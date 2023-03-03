using abb.residential_web.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace abb.residential_web.Permissions;

public class residential_webPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(residential_webPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(residential_webPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<residential_webResource>(name);
    }
}
