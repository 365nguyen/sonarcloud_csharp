using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClassLibrary.Tests
{
    [TestClass]
    public class AccountRepositoryTest:AccountRespository
    {
        [TestMethod]
        public void Add_Test()
        {
            // Prepare
            int a = 1;
            int b = 2;
            int c = 3;
            // Act 
            int result = Add(a, b);
            Assert.IsTrue(c==result);
        }
    }
}
