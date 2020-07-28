using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Siskin.Core.Test
{
    [TestClass]
    public class ResolveServiceTests
    {
        [TestMethod]
        public void WhenServiceIsResolvedThenServiceInfoIsReturned()
        {
            //Arange
            var registryRepositoryMock = new Mock<IRegistryRepository>();

            registryRepositoryMock
                .Setup(mock => mock.ResolveService(It.IsAny<ServiceInfoRequest>()))
                .Returns(new ReolveServiceResult { Succeeded = true });


            var registryRepositoryObject = registryRepositoryMock.Object;

            var request = new ServiceInfoRequest();

            //Act
            var result = registryRepositoryObject.ResolveService(request);

            //Assert
            Assert.IsTrue(result.Succeeded);
        }
    }
}
