using System.Threading.Tasks;
using Abp.Application.Services;
using company.Authorization.Accounts.Dto;

namespace company.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
