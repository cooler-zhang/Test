using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Cooler.UnitTest
{
    [TestFixture]
    public class UnitTest1 : BaseTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestStringParse()
        {
            object abc = null;
            var result = abc as string;
            Debug.WriteLine(result);
            var result2 = (string)abc;
            Debug.WriteLine(result2);
        }

        [Test]
        public void TestDatetimeSerleralize()
        {
            var nowString = JsonConvert.SerializeObject(DateTime.Now);
            Debug.WriteLine(nowString);
            var now = Convert.ToDateTime(nowString);
            var testDate = new DateTime(2019, 10, 10, 0, 0, 0, DateTimeKind.Utc);
            var testString = JsonConvert.SerializeObject(testDate);
            Debug.WriteLine(testString);
        }

        [Test]
        public void TestObjectForEach()
        {
            var items = new List<string>() { "a", "b", "c" };
            items.ForEach(a =>
            {
                if (a == "b")
                    return;
                Console.WriteLine(a);
            });

            Debug.WriteLine("Any:" + items.Any(a => a.Equals("a")));
            Debug.WriteLine("All 1:" + items.All(a => a.Equals("a")));
            Debug.WriteLine("All 2:" + items.All(a => a != null));
        }

        [Test]
        public void Test12HourTo24Hour()
        {
            Debug.WriteLine(DateTime.Parse("04:00 PM").ToString("yyyy-MM-dd HH:mm:ss"));
            Debug.WriteLine(DateTime.Parse("05:05 PM").ToString("yyyy-MM-dd HH:mm:ss"));
            Debug.WriteLine(DateTime.Parse("12:00 PM").ToString("yyyy-MM-dd HH:mm:ss"));
            Debug.WriteLine(DateTime.Parse("00:00 AM").ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}