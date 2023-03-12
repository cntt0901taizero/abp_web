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

namespace abb.residential_web.BlockHouses.Building
{
    //[Authorize]
    public class BuildingAppService :
        BaseCrudAppService<
            BuildingEntity,
            BuildingDto,
            long,
            BuildingPagedAndSortedResultRequestDto,
            BuildingDto>
    {
        private readonly IMediator _mediator;
        public BuildingAppService(
            IAppFactory appFactory,
            IMediator mediator
            ) : base(appFactory)
        {
            _mediator = mediator;

            GetPolicyName = residential_webPermissions.Building.Default;
            GetListPolicyName = residential_webPermissions.Building.Default;
            CreatePolicyName = residential_webPermissions.Building.Create;
            UpdatePolicyName = residential_webPermissions.Building.Update;
            DeletePolicyName = residential_webPermissions.Building.Delete;
        }

    }
}
