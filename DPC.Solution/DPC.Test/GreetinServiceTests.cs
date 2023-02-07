using DPC.Web.Services;

namespace DPC.Test
{
    [TestClass]
    public class GreetinServiceTests
    {
        private readonly IGreetingService _sut;

        public GreetinServiceTests()
        {
            _sut = new GreetingService();
        }

        [TestMethod]
        public void TestMessageIsNotNull()
        {
            Assert.IsNotNull(_sut.SayHelloWorld());
        }

        [TestMethod]
        public void TestMessageIsHelloWorld()
        {
            Assert.AreEqual("Hello world!", _sut.SayHelloWorld());
        }
    }
}