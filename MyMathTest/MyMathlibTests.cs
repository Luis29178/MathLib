using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib.Tests
{
    [TestClass()]
    public class MyMathlibTests
    {
        [TestMethod()]
        public void DefaultConstroctor()
        {
            MyMathlib lib = new MyMathlib();
            if (lib.X == 0.0f && lib.Y == 0.0f)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.Fail();
            }
            
        }
        [TestMethod()]
        public void CustomConstroctor()
        {
            MyMathlib lib = new MyMathlib(2.3f,4.6f);
            if (lib.X == 2.3f && lib.Y == 4.6f)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.Fail();
            }

        }
        
        [TestMethod]
        public void EpsilonTest()
        {
            var lib = new MyMathlib(2.3f,4.6f);
            if (lib.Epsilon == Single.Epsilon)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.Fail();
            }

        }
    }
}