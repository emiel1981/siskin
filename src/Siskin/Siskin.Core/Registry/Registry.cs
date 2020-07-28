using System;
using System.Threading.Tasks;

namespace Siskin.Core
{
    public class Registry : IRegistry
    {
        private readonly IRegistryRepository _registryRepository;

        public Registry(IRegistryRepository registryRepository)
        {
            _registryRepository = registryRepository;
        }

        public RegisterResult RegisterService(ServiceInfo serviceInfo)
        {
            return new RegisterResult { Succeeded = true };
        }

        public async Task<RegisterResult> RegisterServiceAsync(ServiceInfo serviceInfo)
        {
            throw new NotImplementedException();
        }

        public UnRegisterResult UnRegisterService(ServiceInfo serviceInfo)
        {
            throw new NotImplementedException();
        }

        public async Task<UnRegisterResult> UnRegisterServiceAsync(ServiceInfo serviceInfo)
        {
            throw new NotImplementedException();
        }
    }
}
