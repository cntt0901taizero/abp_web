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
        CreateMap<BuildingEntity, BuildingDto>().ReverseMap();
        CreateMap<BuildingFloorsEntity, BuildingFloorsDto>().ReverseMap();
        CreateMap<BuildingHousesEntity, BuildingHousesDto>().ReverseMap();
    }
}
