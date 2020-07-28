using System.Threading.Tasks;

namespace Siskin.Core
{
    public interface IRegistry
    {
        RegisterResult RegisterService(ServiceInfo serviceInfo);
        Task<RegisterResult> RegisterServiceAsync(ServiceInfo serviceInfo);
        UnRegisterResult UnRegisterService(ServiceInfo serviceInfo);
        Task<UnRegisterResult> UnRegisterServiceAsync(ServiceInfo serviceInfo);
    }
}