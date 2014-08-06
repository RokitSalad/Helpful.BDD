using NUnit.Framework;

namespace Helpful.BDD
{
    [TestFixture]
    public abstract class TestBase
    {
        protected TestBase()
        {
            Given();
        }

        protected virtual void Given()
        {
        }

        [TestFixtureSetUp]
        protected abstract void When();
    }
}
