using System.Threading.Tasks;
using Abp.Application.Services;
using Example.Authorization.Accounts.Dto;

namespace Example.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
