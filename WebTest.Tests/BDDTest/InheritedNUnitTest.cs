using System;
using System.Diagnostics;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace WebTest.Tests.Test
{
    [TestFixture]
    public class InheritedTestNUnit
    {
        [Test]
        public void InheritedFooTestMethod()
        {
            Overrider over = new Overrider();
            BaseClass b1 = over;
            over.Foo(); // Overrider.Foo
            b1.Foo(); // Overrider.Foo
            Hider h = new Hider();
            BaseClass b2 = h;
            h.Foo(); // Hider.Foo
            b2.Foo(); // BaseClass.Foo
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
