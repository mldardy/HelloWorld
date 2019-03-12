using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldAPI.Test
{
    [TestClass]
    public class HelloWorldInterfaceAPIShould
    {
        [TestMethod]
        public void ProperlyCreateConsoleBehaviorAndSetMessage()
        {
            //Arrange
            var app = new App();
            
            //Act
            app.setBehavior(new ConsoleBehavior());
            app.setMessage("Hello World");

            //Assert
            Assert.IsInstanceOfType(app.getBehavior(), typeof(ConsoleBehavior));
            Assert.AreEqual("Hello World", app.getMessage());
        }

        [TestMethod]
        public void ProperlyCreateDatabaseBehaviorAndSetMessage()
        {
            //Arrange
            var app = new App();

            //Act
            app.setBehavior(new DatabaseBehavior());
            app.setMessage("Hello World");

            //Assert
            Assert.IsInstanceOfType(app.getBehavior(), typeof(DatabaseBehavior));
            Assert.AreEqual("Hello World", app.getMessage());
        }
    }
}
