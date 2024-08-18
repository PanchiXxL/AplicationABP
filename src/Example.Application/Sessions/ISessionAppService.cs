using System.Threading.Tasks;
using Abp.Application.Services;
using Example.Sessions.Dto;

namespace Example.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
