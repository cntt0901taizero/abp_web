using abb.residential_web.BlockHouses.Dto;
using abb.residential_web.DataEntity;
using abb.residential_web.Permissions;
using BaseApplication.Factory;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abb.residential_web.BlockHouses.BuildingFloors
{
    //[Authorize]
    public class BuildingFloorsAppService :
        BaseCrudAppService<
            BuildingFloorsEntity,
            BuildingFloorsDto,
            long,
            BuildingFloorsPagedAndSortedResultRequestDto,
            BuildingFloorsDto>
    {
        private readonly IMediator _mediator;
        public BuildingFloorsAppService(
            IAppFactory appFactory,
            IMediator mediator
            ) : base(appFactory)
        {
            _mediator = mediator;

            GetPolicyName = residential_webPermissions.BuildingFloors.Default;
            GetListPolicyName = residential_webPermissions.BuildingFloors.Default;
            CreatePolicyName = residential_webPermissions.BuildingFloors.Create;
            UpdatePolicyName = residential_webPermissions.BuildingFloors.Update;
            DeletePolicyName = residential_webPermissions.BuildingFloors.Delete;
        }

    }
}
