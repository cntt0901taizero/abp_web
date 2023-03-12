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
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace abb.residential_web.BlockHouses.BlockHouse
{
    //[Authorize]
    public class BlockHouseAppService :
        BaseCrudAppService<
            BlockHouseEntity,
            BlockHouseDto,
            long,
            BlockHousePagedAndSortedResultRequestDto,
            BlockHouseDto>
    {
        private readonly IMediator _mediator;
        public BlockHouseAppService(
            IAppFactory appFactory,
            IMediator mediator
            ) : base(appFactory)
        {
            _mediator = mediator;

            GetPolicyName = residential_webPermissions.BlockHouse.Default;
            GetListPolicyName = residential_webPermissions.BlockHouse.Default;
            CreatePolicyName = residential_webPermissions.BlockHouse.Create;
            UpdatePolicyName = residential_webPermissions.BlockHouse.Update;
            DeletePolicyName = residential_webPermissions.BlockHouse.Delete;
        }

        //public async Task<long> Test()
        //{
        //    var res = await _mediator.Send(new TestRequest());
        //    return 1;
        //}

    }

}
