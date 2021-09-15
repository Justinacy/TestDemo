
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDemo.TestClass;

//RecordTest recordTest = new RecordTest("chaoyu", "http://caidui.com", "女");
//recordTest.Sex = "男";
//Console.WriteLine(recordTest.Test());
////两种声明方式
//RecordTestOne recordTestOne = new RecordTestOne("chaoyu", "http://caidui.com");
//RecordTestOne recordTestTwo = new("chaoyu", "http://caidui.com");
//Console.WriteLine(recordTestOne.Equals(recordTestTwo));
//Console.WriteLine(ReferenceEquals(recordTestOne, recordTestTwo));

namespace TestDemo.TestClass
{
    /// <summary>
    /// 记录：是一个为处理数据模型提供特殊语法和行为的类
    /// </summary>
    public record RecordTest
    {
        public RecordTest(string name, string url, string sex)
        {
            Name = name;
            Url = url;
            Sex = sex;
        }

        public string Name { get; init; }

        public string Url { get; init; }

        public string Sex { get; set; }

        public string Test()
        {
            return Name;
        }
    }

    public record RecordTestOne(string firstName, string endName);

}
