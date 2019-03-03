using BackendConsoleApp;
using NUnit.Framework;
using static BackendConsoleApp.Factory;

namespace BackendTests
{
    [TestFixture]
    public class Task3Tests
    {
        [Test]
        public void FactoryReturnCorrectObjectTypeForCarProductType()
        {
            var factory = new Factory();
            var productType = ProductType.Car;
            var itemType = CarType.Honda;

            var result = factory.BuildProduct(productType, itemType);

            Assert.That(result, Is.TypeOf<CarProduct>());
        }

        [Test]
        public void FactoryReturnCorrectObjectTypeForRobotProductType()
        {
            var factory = new Factory();
            var productType = ProductType.Robot;
            var itemType = RobotType.RoboticDog;

            var result = factory.BuildProduct(productType, itemType);

            Assert.That(result, Is.TypeOf<RobotProduct>());
        }
    }
}
