using System;
using FunctionLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SmartMenuLibrary;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Result from DoThis", Functions.DoThis());
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("Result from DoThat", Functions.DoThat());
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("Result from Doing: Something", Functions.DoSomething("Something"));
        }
        
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(42, Functions.GetTheAnswerToLifeTheUniverseAndEverything());
        }
    }
}
