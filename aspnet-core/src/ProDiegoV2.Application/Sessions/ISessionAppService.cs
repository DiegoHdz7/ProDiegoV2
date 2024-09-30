using System.Threading.Tasks;
using Abp.Application.Services;
using ProDiegoV2.Sessions.Dto;

namespace ProDiegoV2.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
