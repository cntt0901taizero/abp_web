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

namespace abb.residential_web.BlockHouses.BuildingHouses
{
    //[Authorize]
    public class BuildingHousesAppService :
        BaseCrudAppService<
            BuildingHousesEntity,
            BuildingHousesDto,
            long,
            BuildingHousesPagedAndSortedResultRequestDto,
            BuildingHousesDto>
    {
        private readonly IMediator _mediator;
        public BuildingHousesAppService(
            IAppFactory appFactory,
            IMediator mediator
            ) : base(appFactory)
        {
            _mediator = mediator;

            GetPolicyName = residential_webPermissions.BuildingHouses.Default;
            GetListPolicyName = residential_webPermissions.BuildingHouses.Default;
            CreatePolicyName = residential_webPermissions.BuildingHouses.Create;
            UpdatePolicyName = residential_webPermissions.BuildingHouses.Update;
            DeletePolicyName = residential_webPermissions.BuildingHouses.Delete;
        }

    }
}
