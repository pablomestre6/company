using System.Threading.Tasks;
using Abp.Application.Services;
using company.Sessions.Dto;

namespace company.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
