namespace abb.residential_web.Permissions;

public static class residential_webPermissions
{
    public const string GroupName = "residential_web";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";

    public const string BlockHouses = GroupName + ".BlockHouses";
    public static class BlockHouse
    {
        public const string Default = GroupName + ".BlockHouse";
        public const string View = Default + ".View";
        public const string Create = Default + ".Create";
        public const string Update = Default + ".Update";
        public const string Delete = Default + ".Delete";
    }
    public static class Building
    {
        public const string Default = GroupName + ".Building";
        public const string View = Default + ".View";
        public const string Create = Default + ".Create";
        public const string Update = Default + ".Update";
        public const string Delete = Default + ".Delete";
    }
    public static class BuildingFloors
    {
        public const string Default = GroupName + ".BuildingFloors";
        public const string View = Default + ".View";
        public const string Create = Default + ".Create";
        public const string Update = Default + ".Update";
        public const string Delete = Default + ".Delete";
    }
    public static class BuildingHouses
    {
        public const string Default = GroupName + ".BuildingHouses";
        public const string View = Default + ".View";
        public const string Create = Default + ".Create";
        public const string Update = Default + ".Update";
        public const string Delete = Default + ".Delete";
    }
}
