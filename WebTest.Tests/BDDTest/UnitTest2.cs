using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace WebTest.Tests.Test
{
    [TestClass]
    public class UnitTest2
    {
        static void increment(int i, string s, personStruct ps, personClass pc)
        {
            i++;
            s += "s";
            ps.Age += 1;
            pc.Age += 1;
            return;
        }
        [TestMethod]
        public void TestMethod2()
        { 
        personStruct a = new personStruct { Name = "Raymond", Age = 18 };
        personClass b = new personClass { Name = "Raymond", Age = 18 };

        int i = 18;

        string s = string.Empty;

           increment(i, s, a, b);

        Console.WriteLine("i={0}, s={1}, a={2}, b={3}", i, s , a.Age, b.Age);

           increment(i, s, a, b);

        Console.WriteLine("i={0}, s={1}, a={2}, b={3}", i, s, a.Age, b.Age);
        }
        [TestMethod]
        public void TestMethod1()
        {
            var listPersonne = new List<personClass>()
            {
            new personClass { Name="Pierre", Age=24 },
            new personClass { Name="Paul", Age=56 },
            new personClass { Name="Jacques", Age=34 },
            new personClass { Name="Annie", Age=29 }
            };

            var result = listPersonne.Where(p => p.Age < 30);

            listPersonne.Add(new personClass { Name = "Jeanne", Age = 27 });

            foreach (var p in result)
            {
                Trace.WriteLine(p.Name + " ");
            }

            var result2 = listPersonne.OrderBy(mc => mc.Age)
                   .ToDictionary(mc => mc.Age.ToString(),
                                 mc => mc.Name.ToString(),
                                 StringComparer.OrdinalIgnoreCase);

            var pivot = 21f;
            var closestBelow = pivot - listPersonne.Where(n => n.Age <= pivot).Min(n => pivot - n.Age);


            /*
            
            var minDistance = numbers.Min(n => Math.Abs(pivot - n));
            var closest = numbers.First(n => Math.Abs(pivot - n) == minDistance);
            
            */



        }
    }
    struct personStruct
    {

        public string Name;

        public int Age;

    }
    public class personClass
    {
        public string Name;
        public int Age;
    }    
}

