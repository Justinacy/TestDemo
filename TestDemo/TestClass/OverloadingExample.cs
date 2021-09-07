using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    //重载(方法名称一致)
    public class OverloadingExample
    {
        public void F() => Console.WriteLine("");

        public void F(int x) => Console.WriteLine(x);

        public void F(double x) => Console.WriteLine(x);

        public float F(float x) => x;
    }
}
