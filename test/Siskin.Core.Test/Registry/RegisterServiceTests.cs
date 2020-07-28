using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Siskin.Core.Test
{
    [TestClass]
    public class RegisterServiceTests
    {
        [TestMethod]
        public void WhenServiceIsRegisteredThenAnOkResponseIsReturned()
        {
            //Arange
            var registryRepositoryMock = new Mock<IRegistryRepository>().Object;
            var registry = new Registry(registryRepositoryMock);
            var serviceInfo = new ServiceInfo();

            //Act
            var result = registry.RegisterService(serviceInfo);

            //Assert
            Assert.IsTrue(result.Succeeded);
        }
    }
}
