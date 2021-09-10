using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestClass;
using TestDemo.TestClass;

namespace TestDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var parm = new RefOutInTest();

            var list = new List<Animal>();
            list.Add(new Fish());
            list.Add(new Dog());

            var vistor = new Vistor();

            foreach (var item in list)
            {
                vistor.Vist(item);

            }

            parm.Test();

            int x = 3, y = 4, z = 5;

            string s = "x={0} y={1} z={2}";
            object[] arry = new object[4];
            arry[0] = x;
            arry[1] = y;
            arry[2] = z;
            arry[3] = 6;
            Console.WriteLine(s, arry);

            Entity e1 = new Entity();
            //类实例调用
            e1.SValue();
            //类调用
            Entity.StaticValue();

            #region 特性
            //获取这个类的类型数组(只读)
            Type attribute = typeof(AttributeTest);

            //返回自定义属性数组
            object[] attributeArry = attribute.GetCustomAttributes(typeof(HelpAttribute), false);
            if (attributeArry.Any())
            {
                HelpAttribute attributeTest = (HelpAttribute)attributeArry[0];
                Console.WriteLine($"AttributeTest class help URL : {attributeTest.Url} - Related topic : {attributeTest.Topic}");
            }

            //获取DisPlay方法的属性
            System.Reflection.MethodInfo disPlay = attribute.GetMethod(nameof(AttributeTest.DisPlay));

            //返回自定义属性数组
            object[] disPlayArry = disPlay.GetCustomAttributes(typeof(HelpAttribute), false);

            if (disPlayArry.Any())
            {
                HelpAttribute helpAttributeDisPlay = (HelpAttribute)disPlayArry[0];
                Console.WriteLine($"AttributeTest class help URL : {helpAttributeDisPlay.Url} - Related topic : {helpAttributeDisPlay.Topic}");
            }
            #endregion

            #region 字符串
            string stringTest = "   Mary  ";

            Console.WriteLine(stringTest);

            //新的字符串，而不是原来的字符串
            stringTest.Trim();

            Console.WriteLine(stringTest.Trim());

            string stringTestSearch = "hello,Are you ok";

            Console.WriteLine(stringTestSearch.StartsWith("hello") && stringTestSearch.EndsWith("ok"));
            Console.WriteLine(stringTestSearch.StartsWith("hello") && stringTestSearch.EndsWith("you"));
            #endregion

            #region 数字
            int max = int.MaxValue;
            int mix = int.MinValue;
            Console.WriteLine($"max：{max},min:{mix}");

            int maxUp = max + 2;
            Console.WriteLine($"超过界限值产生溢出：{maxUp}");

            double maxDouble = double.MaxValue;
            double mixDouble = double.MaxValue;
            Console.WriteLine($"maxDouble：{maxDouble},mixDouble:{mixDouble}");

            //for
            double cirle = Math.PI * 2.50 * 2.50;
            Console.WriteLine(cirle);

            #endregion

            #region 斐波那契数列(前20项)
            var fibonacciNumbers = new List<int> { 1, 1 };

            while (fibonacciNumbers.Count < 20)
            {
                var fibonacciNumbersPre = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var fibonacciNumbersNext = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(fibonacciNumbersPre + fibonacciNumbersNext);
            }
            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }
            #endregion

            var value = AsyncConsoleWork().GetAwaiter().GetResult();
            Console.WriteLine(value);

           
            #region 泛型

            #endregion
        }

        private static async Task<int> AsyncConsoleWork()
        {
            // Main body here
            return 0;
        }
    }
}
