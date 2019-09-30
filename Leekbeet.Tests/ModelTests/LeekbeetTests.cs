using Microsoft.VisualStudio.TestTools.UnitTesting;
using Translator;

namespace Translator.Test
{
    [TestClass]
    public class LeekbeetTest
    {
        [TestMethod]
        public void Translate_TurnAwordstoAsparagus_Asparagus()
        {
            Leekbeet testLeekbeet = new Leekbeet();
            Assert.AreEqual("asparagus", testLeekbeet.Translate("animal"));
        }
    }
}