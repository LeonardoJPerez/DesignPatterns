using NUnit.Framework;

namespace PatternsTest
{
    [TestFixture]
    public class AdapterPatternTest
    {
        [Test]
        public void RunObjectAdapterTest()
        {
            var client = new AdapterPattern.Object.Client();
            client.DoWork();

            Assert.Pass();
        }

        [Test]
        public void RunClassAdapterTest()
        {
            var client = new AdapterPattern.Class.Client();
            client.DoWork();

            Assert.Pass();
        }
    }
}