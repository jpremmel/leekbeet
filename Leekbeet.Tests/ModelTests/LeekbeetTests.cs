using Microsoft.VisualStudio.TestTools.UnitTesting;
using Translator;

namespace Translator.Test
{
    [TestClass]
    public class LeekbeetTest
    {
        Leekbeet testLeekbeet = new Leekbeet();

        [TestMethod]
        public void Translate_TurnAwordstoAsparagus_Asparagus()
        {
            Assert.AreEqual("asparagus", testLeekbeet.Translate("animal"));
        }
        [TestMethod]
        public void Translate_TurnBwordstoBeet_Beet()
        {
            Assert.AreEqual("beet", testLeekbeet.Translate("banana"));
        }
        [TestMethod]
        public void Translate_TurnCwordstoCarrot_Carrot()
        {
            Assert.AreEqual("carrot", testLeekbeet.Translate("cat"));
        }
        [TestMethod]
        public void Translate_TurnDwordstoDill_Dill()
        {
            Assert.AreEqual("dill", testLeekbeet.Translate("dog"));
        }
        [TestMethod]
        public void Translate_TurnEwordstoEggplant_Eggplant()
        {
            Assert.AreEqual("eggplant", testLeekbeet.Translate("elephant"));
        }
        [TestMethod]
        public void Translate_TurnFwordstoFennel_Fennel()
        {
            Assert.AreEqual("fennel", testLeekbeet.Translate("ferret"));
        }
        [TestMethod]
        public void Translate_TurnGwordstoGarlic_Garlic()
        {
            Assert.AreEqual("garlic", testLeekbeet.Translate("gopher"));
        }
        [TestMethod]
        public void Translate_TurnHwordstoHorseradish_Horseradish()
        {
            Assert.AreEqual("horseradish", testLeekbeet.Translate("hexagon"));
        }
        [TestMethod]
        public void Translate_TurnIwordstoIcebergLettuce_IcebergLettuce()
        {
            Assert.AreEqual("iceberg lettuce", testLeekbeet.Translate("international"));
        }
        [TestMethod]
        public void Translate_TurnJwordstoJicama_Jicama()
        {
            Assert.AreEqual("jicama", testLeekbeet.Translate("joyful"));
        }
        [TestMethod]
        public void Translate_TurnKwordstoKale_Kale()
        {
            Assert.AreEqual("kale", testLeekbeet.Translate("kayak"));
        }
        [TestMethod]
        public void Translate_TurnLwordstoLeek_Leek()
        {
            Assert.AreEqual("leek", testLeekbeet.Translate("llama"));
        }
        [TestMethod]
        public void Translate_TurnMwordstoMint_Mint()
        {
            Assert.AreEqual("mint", testLeekbeet.Translate("mike"));
        }
        [TestMethod]
        public void Translate_TurnNwordstoNutmeg_Nutmeg()
        {
            Assert.AreEqual("nutmeg", testLeekbeet.Translate("night"));
        }
        [TestMethod]
        public void Translate_TurnOwordstoOnion_Onion()
        {
            Assert.AreEqual("onion", testLeekbeet.Translate("opal"));
        }
        [TestMethod]
        public void Translate_TurnPwordstoPotato_Potato()
        {
            Assert.AreEqual("potato", testLeekbeet.Translate("parrot"));
        }
        [TestMethod]
        public void Translate_TurnQwordstoQuinoa_Quinoa()
        {
            Assert.AreEqual("quinoa", testLeekbeet.Translate("quail"));
        }
        [TestMethod]
        public void Translate_TurnRwordstoRadish_Radish()
        {
            Assert.AreEqual("radish", testLeekbeet.Translate("rhino"));
        }
        [TestMethod]
        public void Translate_TurnSwordstoSquash_Squash()
        {
            Assert.AreEqual("squash", testLeekbeet.Translate("snake"));
        }
        [TestMethod]
        public void Translate_TurnTwordstoTurnip_Turnip()
        {
            Assert.AreEqual("turnip", testLeekbeet.Translate("tedious"));
        }
        [TestMethod]
        public void Translate_TurnUwordstoUnagi_Unagi()
        {
            Assert.AreEqual("unagi", testLeekbeet.Translate("usually"));
        }
        [TestMethod]
        public void Translate_TurnVwordstoVanilla_Vanilla()
        {
            Assert.AreEqual("vanilla", testLeekbeet.Translate("velociraptor"));
        }
        [TestMethod]
        public void Translate_TurnWwordstoWatercress_Watercress()
        {
            Assert.AreEqual("watercress", testLeekbeet.Translate("wolf"));
        }
        [TestMethod]
        public void Translate_TurnXwordstoXigua_Xigua()
        {
            Assert.AreEqual("xigua", testLeekbeet.Translate("xray"));
        }
        [TestMethod]
        public void Translate_TurnYwordstoYam_Yam()
        {
            Assert.AreEqual("yam", testLeekbeet.Translate("yet"));
        }
        [TestMethod]
        public void Translate_TurnZwordstoZucchini_Zucchini()
        {
            Assert.AreEqual("zucchini", testLeekbeet.Translate("zebra"));
        }
    }
}