using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace Unit_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                HelloWorld.Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual("Hello World!", result);
            }
        }
    }
}