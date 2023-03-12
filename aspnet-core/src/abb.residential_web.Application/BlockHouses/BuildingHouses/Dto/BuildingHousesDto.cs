using abb.residential_web.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace abb.residential_web.BlockHouses.Dto
{
    public class BuildingHousesDto : AuditedEntityDto<long>
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public HouseTypeEnum HouseType { get; set; } = HouseTypeEnum.Normal;

        public string AreaApartment { get; set; }
        public string BedroomNumber { get; set; }
        public string BathroomNumber { get; set; }
        public string BalconyNumber { get; set; }
        public string FeeBase { get; set; }
        public string DetailedDescription { get; set; }

        public bool IsActive { get; set; } = true;
    }

    public class CruBuildingHousesDto : AuditedEntityDto<long>
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public HouseTypeEnum HouseType { get; set; } = HouseTypeEnum.Normal;

        public string AreaApartment { get; set; }
        public string BedroomNumber { get; set; }
        public string BathroomNumber { get; set; }
        public string BalconyNumber { get; set; }
        public string FeeBase { get; set; }
        public string DetailedDescription { get; set; }

        public bool IsActive { get; set; } = true;
    }

    public class BuildingHousesPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
        public int PageNumber { get; set; }
    }
}
