using NUnit.Framework;
using Sba.DotNetUtils.Tabulate;

namespace Sba.DotNetUtils.Tabulate_UT {
    [TestFixture]
    public class Tests {
        [Test]
        public void TabulateLeftAlign() {
            Assert.AreEqual("a   ", "a".Tabulate(-4));
        }
        
        [Test]
        public void TabulateRightAlign() {
            Assert.AreEqual("   a", "a".Tabulate(4));
        }
        
        [Test]
        public void TabulateLeftAlignFillWithPeriods() {
            Assert.AreEqual("a...", "a".Tabulate(-4, '.'));
        }
    }
}