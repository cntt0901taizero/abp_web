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
    public class BuildingFloorsDto : AuditedEntityDto<long>
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public int Sort { get; set; }
        public int TotalHouse { get; set; }
        public FloorsTypeEnum FloorsType { get; set; } = FloorsTypeEnum.Undefined;
        public bool IsActive { get; set; } = true;
    }

    public class CruBuildingFloorsDto : AuditedEntityDto<long>
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public int Sort { get; set; }
        public int TotalHouse { get; set; }
        public FloorsTypeEnum FloorsType { get; set; } = FloorsTypeEnum.Undefined;
        public bool IsActive { get; set; } = true;
    }

    public class BuildingFloorsPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
        public int PageNumber { get; set; }
    }
}
