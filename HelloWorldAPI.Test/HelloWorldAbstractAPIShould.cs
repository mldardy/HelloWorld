using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldAPI.Test
{
    [TestClass]
    public class HelloWorldAbstractAPIShould
    {
        [TestMethod]
        public void CreateConsoleBehaviorAndSetMessage()
        {
            //Arrange
            HelloWorldConsole conApp = new HelloWorldConsole();
            
            //Act
            conApp.SetMessage("Hello World");

            //Assert
            Assert.IsNotNull(conApp);
            Assert.AreEqual("Hello World", conApp.ConsoleMessage);
        }

        [TestMethod]
        public void CreateDatabaseBehaviorAndSetMessage() 
        {
            //Arrange
            HelloWorldDatabase dbApp = new HelloWorldDatabase();

            //Act
            dbApp.SetMessage("Hello World");

            //Assert
            Assert.IsNotNull(dbApp);
            Assert.AreEqual("Hello World", dbApp.ConsoleMessage);
        }
    }
}
