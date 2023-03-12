using BaseApplication.Dtos;
using BaseApplication.Factory;
using Dapper;
using System;
using System.Threading.Tasks;

namespace BaseApplication.BaseBusiness
{
    public class BaseBussiness
    {
        public static async Task<UserSessionDto> GetUser(IDbConnectionFactory db, Guid userId)
        {
            var query = $@"select u.Id, u.TenantId, u.UserName, u.Name, u.Surname, 
            u.Email, u.PhoneNumber, u.IsActive, u.CreationTime
            from AbpUsers u where u.USERID = @UserId";

            return await db.Connection.QueryFirstOrDefaultAsync<UserSessionDto>(query, new
            {
                UserId = userId.ToString()
            });

        }
    }
}
