using System;
using kaffe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace kaffeTests
{
    [TestClass]
    public class FlatWhiteTest
    {
        [TestMethod]
        public void FlatWhitePrisTest()
        {
            //Arrange
            var flatwhite = new FlatWhite();

            //Act
            int prisFlatwhite = flatwhite.Pris();

            //Assert
            Assert.AreEqual(45, prisFlatwhite);
        }

        [TestMethod]
        public void FlatWhiteStyrkeTest()
        {
            //Arrange
            var flatwhite = new FlatWhite();

            //Act
            flatwhite.Styrke();
        }

        [TestMethod]
        public void FlatWhiteMælkTest()
        {
            //Arrange
            var flatwhite = new FlatWhite();

            //Act
            flatwhite.MlMælk();
        }




    }
}
