using System.Runtime.InteropServices;
using System.Linq;
using System;
using System.Collections.Generic;
using ConsoleAppTest.NullObjectPattern;
using Newtonsoft.Json;

namespace ConsoleAppTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TestStringParse();
            Console.ReadLine();
        }

        public static void TestStringParse()
        {
            object abc = null;
            var result = abc as string;
            Console.WriteLine(result);
            var result2 = (string)abc;
            Console.WriteLine(result2);
        }

        public static void TestDatetimeSerleralize()
        {
            var nowString = JsonConvert.SerializeObject(DateTime.Now);
            Console.WriteLine(nowString);
            var now = Convert.ToDateTime(nowString);
            var testDate = new DateTime(2019, 10, 10, 0, 0, 0, DateTimeKind.Utc);
            var testString = JsonConvert.SerializeObject(testDate);
            Console.WriteLine(testString);
        }

        public static void TestNullObjectPattern()
        {
            var nullService = NullService.Instance;
            var service = nullService as IService;
            Console.WriteLine("service:" + service);
            var productService = nullService as IProductService;
            Console.WriteLine("ProductService:" + productService);
        }

        public static void TestObjectForEach()
        {
            var items = new List<string>() { "a", "b", "c" };
            items.ForEach(a =>
            {
                if (a == "b")
                    return;
                Console.WriteLine(a);
            });

            Console.WriteLine("Any:" + items.Any(a => a.Equals("a")));
            Console.WriteLine("All 1:" + items.All(a => a.Equals("a")));
            Console.WriteLine("All 2:" + items.All(a => a != null));
        }

        public static void Test12HourTo24Hour()
        {
            Console.WriteLine(DateTime.Parse("04:00 PM").ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine(DateTime.Parse("05:05 PM").ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine(DateTime.Parse("12:00 PM").ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine(DateTime.Parse("00:00 AM").ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}