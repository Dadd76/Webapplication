using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebTest.Tests.Test
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void SingletonTest()
        {
            Singleton MySingleton = Singleton.Instance;
            MySingleton = Singleton.Instance;
        }
    }


    public sealed class Singleton
    {
        private static volatile Singleton instance;
        private static object syncRoot = new Object();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new Singleton();
                    }
                }

                return instance;
            }
        }
    }
}

