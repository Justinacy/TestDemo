
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDemo.TestClass;

////创建对象引用但并未创建对象(对象引用并未引用对象)
//ClassTest testClass1;

////testClass1.TestClass();testClass1引用未创建对象直接访问对象失败

////创建对象引用，并创建对象,testClass2是对象引用但是并不包含对象数据本身，使用new关键字才是创建对象(类的实例或者对象)
//ClassTest testClass2 = new ClassTest();

////不同的对象引用，引用同一个对象,修改testClass2 都对反应在testClass3的后续使用上
//ClassTest testClass3;
//testClass3 = testClass2;
//Console.WriteLine(ReferenceEquals(testClass3, testClass2));

namespace TestDemo.TestClass
{
    /// <summary>
    /// 类 一个类只可继承一个基类
    /// </summary>
    public class ClassTest
    {
        public void TestClass()
        {

        }
    }

    public class Monkey
    {
        public virtual void Leg()
        {
        }

        public void Foot()
        {

        }
    }

    public class MonkeyOne : Monkey
    {
        public override void Leg()
        {
            Console.WriteLine("猴子一号");
        }
    }

    public sealed class MonkeyTwo : Monkey
    {
        public override void Leg()
        {
            Console.WriteLine("猴子二号");
        }
    }
    
    /// <summary>
    /// 密封类不可被继承
    /// </summary>
    //public class MonkeyThree : MonkeyTwo { }
}
