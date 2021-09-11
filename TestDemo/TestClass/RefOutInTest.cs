using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo.TestClass
{
    /// <summary>
    /// 方法参数修饰符 ref out in
    /// </summary>
    public class RefOutInTest
    {

        public void Test()
        {
            int value1 = 20;

            int value2;

            var testDto = new TestDto();

            Console.WriteLine("in 参数 只能从外部把值传入方法内部使用");
            InTest1(in value1);
            //InTest1(in int value3);//不能直接定义
            //InTest1(in 10); In后不能是实际的数值
            // InTest1(in value2);错误，不能是没有赋值的变量
            // InTest2(in TestDto testDto1); 错误,in后不能是实际的数据
            InTest2(in testDto);


            Console.WriteLine("out 参数，是从方法内部把数据带出来");
            //定义调用分开
            OutTest1(out value1);
            OutTest1(out value2);//即使赋值，方法内部接收不到
            OutTest2(out testDto);
            //定义调用一起
            OutTest1(out int value3);
            OutTest2(out TestDto testDto2);



            Console.WriteLine("ref 参数，即能把外部的数据传入，也能把方法里的参数变化值传出，这里更多的是把参数转成一个引用，穿透方法内外共享");
            //RefTest1(ref 50);//错误，这里只能传入一个变量，不能是具体的数据
            RefTest1(ref value1);
            RefTest1(ref value2);
            RefTest2(ref testDto);
            // RefTest2(ref TestDto testDto3); //错误
        }

        public void InTest1(in int invalue)
        {
            // invalue = 30; //错误 ，但当参数为object时，可为参数成员赋值
            Console.WriteLine(invalue);
        }

        public void InTest2(in TestDto testDto)
        {
            // testDto = new TestDto(); 错误
            testDto.name = "hello,world!";
            Console.WriteLine(testDto);
        }


        public void OutTest1(out int outvalue)
        {
            // Console.WriteLine(refvalue); 错误
            outvalue = 10; //带有out的参数，在方法内即使有值，也能不使用，只有赋值后才能使用
            Console.WriteLine(outvalue);
        }

        public void OutTest2(out TestDto testDto)
        {
            // Console.WriteLine(testDto); 错误
            // testDto.name = "hello,world!"; 错误
            testDto = new TestDto();//赋值之后才可使用
            Console.WriteLine(testDto);
        }


        public void RefTest1(ref int refvalue)
        {
            Console.WriteLine("前" + refvalue);
            refvalue = 40;
            Console.WriteLine("后" + refvalue);
        }

        public void RefTest2(ref TestDto testDto)
        {
            Console.WriteLine("前" + testDto);
            testDto.name = "hi!";
            Console.WriteLine("后" + testDto);
        }
    }

    public class TestDto
    {
        public int id { get; set; }

        public string name { get; set; }
    }

}
