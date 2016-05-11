using AdapterPattern.Object;
using NUnit.Framework;

namespace PatternsTest
{
    [TestFixture]
    public class AdapterPatternTest
    {
        [Test]
        public void Run()
        {
            var client = new Client();
            client.DoWork();

            Assert.Pass();
        }
    }
}