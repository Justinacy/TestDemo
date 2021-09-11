using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo.TestClass
{
    /// <summary>
    /// 简单的访问者模式
    /// </summary>
    public class Animal
    {
        public virtual void Accpet(Animal animal)
        {

        }
    }

    public class Vistor
    {
        public void Vist(Animal animal)
        {
            animal.Accpet(animal);
        }
    }

    public class Fish : Animal
    {
        public void Swim()
        {
            Console.WriteLine("鱼");
        }

        public override void Accpet(Animal animal)
        {
            this.Swim();
        }
    }

    public class Dog : Animal
    {
        public void Leg()
        {
            Console.WriteLine("狗");
        }

        public override void Accpet(Animal animal)
        {
            this.Leg();
        }
    }
}
