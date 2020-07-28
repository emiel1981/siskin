namespace Siskin.Core
{
    public interface IRegistryRepository
    {
        ReolveServiceResult ResolveService(ServiceInfoRequest request);
    }
}