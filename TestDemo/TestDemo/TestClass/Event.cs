using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass
{
    /// <summary>
    /// 事件
    /// </summary>
    public class Event
    {

        static int sValue;

        static void ListChanged(object sender, EventArgs eventArgs)
        {
            sValue++;
        }

        public static void Uage()
        {

        }
    }
}
