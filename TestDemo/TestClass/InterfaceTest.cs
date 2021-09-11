using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo.TestClass
{
    /// <summary>
    /// 一个类可实现多个接口
    /// </summary>
    public class InterfaceTestOne : IInterfaceTestOne, IInterfaceTestTwo, IInterfaceTestThree<object>
    {
        public virtual bool Equals(object obj)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// 结构可实现多个接口
    /// </summary>
    public struct InterfaceTestOneTwo : IInterfaceTestOne, IInterfaceTestTwo, IInterfaceTestThree<object>
    {
        public bool Equals(object obj)
        {
            throw new NotImplementedException();
        }
    }

    public interface IInterfaceTestOne : IInterfaceTestThree<object>
    {
        //public IInterfaceTestOne() { } error 实例构造函数
        //int a = 0; error 实例字段
        static IInterfaceTestOne() { }

    }

    public interface IInterfaceTestTwo
    {

    }

    public interface IInterfaceTestThree<T>
    {
        bool Equals(T obj);

    }
}

