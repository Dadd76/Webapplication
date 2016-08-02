using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Diagnostics;

namespace WebTest.Tests.Test
{
    [TestClass]
    public class InheritedTest
    {
        [TestMethod]
        public void InheritedTestMethod()
        {
            StringBuilder sb = new StringBuilder();

            A testa = new B { b = 2 }; 
            sb.Append(testa.methodA()); // A 
            sb.Append(testa.methodB()); // b

            B testb = new B();
            A test = (A)testb;
            sb.Append(test.methodA()); // A
            sb.Append(test.methodB()); // b

            A testc = new C();
            sb.Append(testc.methodA()); // A
            sb.Append(testc.methodB()); // b

            B testb2 = new C();
            sb.Append(testb2.methodA()); // A
            sb.Append(testb2.methodB()); // 2

            Trace.WriteLine(sb.ToString()); //Ab Ab Ab A2
            // AbAbAbA2
            B toto = (B)testa;

        }

        public class A
        {
            internal int a;

            public virtual string methodA()
            {
                return "a";
            }

            public virtual string methodB()
            {
                return "b";
            }
        }

        public class B : A 
        {
            public int b;
            public override string methodA()
            {
                return "A";
            }

           // le mot clé new masque explicitement un membre qui est hérité d'une classe de base
            public new virtual string methodB()
            {
                return "B";
            }

        }

        public class C : B
        {
            public new string methodA()
            {
                return "1";
            }

            public override string methodB()
            {
                return "2"; 
            }
        }
    }
}
