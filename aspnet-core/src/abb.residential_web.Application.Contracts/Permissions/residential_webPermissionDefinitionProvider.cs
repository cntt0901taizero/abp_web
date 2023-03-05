using abb.residential_web.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace abb.residential_web.Permissions;

public class residential_webPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(residential_webPermissions.GroupName, L("Menu:residential_web"));
        //Define your own permissions here. Example:
        //myGroup.AddPermission(residential_webPermissions.MyPermission1, L("Permission:MyPermission1"));

        var BlockHouses = myGroup.AddPermission(residential_webPermissions.BlockHouses, L("Permission:BlockHouses"));
        
        var BlockHouse = BlockHouses.AddChild(residential_webPermissions.BlockHouse.Default, L("Permission:BlockHouse"));
        BlockHouse.AddChild(residential_webPermissions.BlockHouse.View, L("Permission:BlockHouse.View"));
        BlockHouse.AddChild(residential_webPermissions.BlockHouse.Create, L("Permission:BlockHouse.Create"));
        BlockHouse.AddChild(residential_webPermissions.BlockHouse.Update, L("Permission:BlockHouse.Update"));
        BlockHouse.AddChild(residential_webPermissions.BlockHouse.Delete, L("Permission:BlockHouse.Delete"));
        var Building = BlockHouses.AddChild(residential_webPermissions.Building.Default, L("Permission:BlockHouse"));
        Building.AddChild(residential_webPermissions.BlockHouse.View, L("Permission:BlockHouse.View"));
        Building.AddChild(residential_webPermissions.BlockHouse.Create, L("Permission:BlockHouse.Create"));
        Building.AddChild(residential_webPermissions.BlockHouse.Update, L("Permission:BlockHouse.Update"));
        Building.AddChild(residential_webPermissions.BlockHouse.Delete, L("Permission:BlockHouse.Delete"));
        var BuildingFloors = BlockHouses.AddChild(residential_webPermissions.BuildingFloors.Default, L("Permission:BlockHouse"));
        BuildingFloors.AddChild(residential_webPermissions.BlockHouse.View, L("Permission:BlockHouse.View"));
        BuildingFloors.AddChild(residential_webPermissions.BlockHouse.Create, L("Permission:BlockHouse.Create"));
        BuildingFloors.AddChild(residential_webPermissions.BlockHouse.Update, L("Permission:BlockHouse.Update"));
        BuildingFloors.AddChild(residential_webPermissions.BlockHouse.Delete, L("Permission:BlockHouse.Delete"));
        var BuildingHouses = BlockHouses.AddChild(residential_webPermissions.BuildingHouses.Default, L("Permission:BlockHouse"));
        BuildingHouses.AddChild(residential_webPermissions.BlockHouse.View, L("Permission:BlockHouse.View"));
        BuildingHouses.AddChild(residential_webPermissions.BlockHouse.Create, L("Permission:BlockHouse.Create"));
        BuildingHouses.AddChild(residential_webPermissions.BlockHouse.Update, L("Permission:BlockHouse.Update"));
        BuildingHouses.AddChild(residential_webPermissions.BlockHouse.Delete, L("Permission:BlockHouse.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<residential_webResource>(name);
    }
}
