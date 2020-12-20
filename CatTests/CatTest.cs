using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cats;

namespace CatTests
{
    [TestClass]
    public class CatTest
    {
        [TestMethod]
        public void InheritsBaseinfirstConstructor()
        {
            HouseCat keyboardCat = new HouseCat("Keyboard Cat", 7);
            Assert.AreEqual(7, keyboardCat.Weight, .001);
        }

        [TestMethod]
        public void InheritsDefaultCatInSecondConstructor()
        {
            HouseCat keyboardCat = new HouseCat("Keyboard Cat");
            Assert.AreEqual(13, keyboardCat.Weight, .001);
        }

        [TestMethod]
        public void IsNotInitiallyTired()
        {
            HouseCat keyboardCat = new HouseCat("Keyboard Cat");
            Assert.IsFalse(keyboardCat.Hungry);
            Assert.IsFalse(keyboardCat.Tired);
            keyboardCat.Eat();
            Assert.IsTrue(keyboardCat.Tired);
        }
    }
}
