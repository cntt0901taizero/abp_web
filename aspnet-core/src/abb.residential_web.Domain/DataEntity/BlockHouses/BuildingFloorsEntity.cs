using abb.residential_web.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace abb.residential_web.DataEntity
{
    [Table(name: "tb_building_floors")]
    public class BuildingFloorsEntity : AuditedAggregateRoot<long>
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public int Sort { get; set; }
        public int TotalHouse { get; set; }
        public FloorsTypeEnum FloorsType { get; set; }
        public bool IsActive { get; set; }
    }
}
