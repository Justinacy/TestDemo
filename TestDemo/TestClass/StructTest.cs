using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDemo.TestClass;

StructTest structTest1 = new StructTest("","");

namespace TestDemo.TestClass
{
    public struct StructTest
    {
        public string Name { get; set; }

        public string Sex { get; set; }

        public StructTest(string name, string sex)
        {
            Sex = sex;
            Name = name;
        }
    }
}
