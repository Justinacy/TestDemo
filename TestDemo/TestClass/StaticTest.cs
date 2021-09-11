using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo.TestClass
{
    public class Entity
    {
        static int staticValue;
        int sValue;

        public Entity()
        {
            sValue = staticValue++;
        }

        public int SValue()
        {
            //未使用 static 修饰符声明的方法是实例方法。
            //实例方法对特定的实例起作用，并能够访问静态和实例成员。
            //其中调用实例方法的实例可以作为 this 显式访问。 在静态方法中引用 this 会生成错误。
            this.sValue = 2;
            // this.staticValue = 1;error
            return sValue;
        }


        public static int StaticValue()
        {
            //使用 static 修饰符声明的方法是静态方法 静态方法不对特定的实例起作用，只能直接访问静态成员
            //return sValue; error
            return staticValue;
        }

    }
}
