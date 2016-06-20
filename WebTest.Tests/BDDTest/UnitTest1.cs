using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Diagnostics;

namespace WebTest.Tests.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            A testa     = new B { b = 2 };
            B testb     = new B();
            A test      = (A)testb;
            A testc     = new C();
            B testb2    = new C();

            
            B toto = (B)testa;


           
            StringBuilder sb = new StringBuilder();

            sb.Append(testa.methodA());
            sb.Append(testa.methodB());

            sb.Append(test.methodA());
            sb.Append(test.methodB());

            sb.Append(testc.methodA());
            sb.Append(testc.methodB());

            sb.Append(testb2.methodA());
            sb.Append(testb2.methodB());

            Trace.WriteLine(sb.ToString()); //Ab Ab Ab A2

        }

        public class A
        {
            public int a;

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
