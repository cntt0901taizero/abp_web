using abb.residential_web.BlockHouses.Dto;
using abb.residential_web.DataEntity;
using AutoMapper;

namespace abb.residential_web;

public class residential_webApplicationAutoMapperProfile : Profile
{
    public residential_webApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<BlockHouseEntity, BlockHouseDto>().ReverseMap();
        CreateMap<CruBlockHouseDto, BlockHouseEntity>().ReverseMap();

        CreateMap<BuildingEntity, BuildingDto>().ReverseMap();
        CreateMap<CruBuildingDto, BuildingEntity>().ReverseMap();

        CreateMap<BuildingFloorsEntity, BuildingFloorsDto>().ReverseMap();
        CreateMap<CruBuildingFloorsDto, BuildingFloorsEntity>().ReverseMap();

        CreateMap<BuildingHousesEntity, BuildingHousesDto>().ReverseMap();
        CreateMap<CruBuildingHousesDto, BuildingHousesEntity>().ReverseMap();
    }

}
