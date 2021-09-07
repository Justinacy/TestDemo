using System;
using System.Collections.Generic;
using TestClass;

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
        }
    }
}
