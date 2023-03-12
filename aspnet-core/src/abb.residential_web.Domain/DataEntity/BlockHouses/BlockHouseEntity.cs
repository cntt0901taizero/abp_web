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
    [Table(name: "TbBlockHouse")]
    public class BlockHouseEntity : AuditedAggregateRoot<long>
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }
        public string Code { get; set; }
        public string InvestorName { get; set; }
        public byte Image { get; set; }
        public string Website { get; set; }
        public string Phone { get; set; }
        public string LocationLink { get; set; }
        public bool IsActive { get; set; }
    }
}
