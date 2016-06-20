using System;
using System.Diagnostics;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace WebTest.Tests.Test
{

    // test commit 2 sf
    [TestFixture]
    public class InheritedTest
    {
        [Test]
        public void TestMethod1()
        {
            Overrider over = new Overrider();
            BaseClass b1 = over;
            over.Foo(); // Overrider.Foo
            b1.Foo(); // Overrider.Foo
            Hider h = new Hider();
            BaseClass b2 = h;
            h.Foo(); // Hider.Foo
            b2.Foo(); // BaseClass.Foo
            Console.WriteLine("qisudisqudsdq");
            Trace.WriteLine("ererereerer");
        }
        [Test]
        public void NunitTest()
        {



        }

        [Test]
        public void TestDescription()
        {
            //Assert.IsTrue(Program.Description.Length, Is.GreaterThan(0));
        }

        public class BaseClass
        {
            public virtual void Foo() { Trace.WriteLine("BaseClass.Foo"); }
        }
        public class Overrider : BaseClass
        {
            public override void Foo() { Trace.WriteLine("Overrider.Foo"); }
        }
        public class Hider : BaseClass
        {
            public new void Foo() { Trace.WriteLine("Hider.Foo"); }
        }
    }
}
