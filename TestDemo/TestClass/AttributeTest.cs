
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo.TestClass
{

    public class HelpAttribute : Attribute
    {
        string _url;
        string _topic;

        public HelpAttribute(string url)
        {
            _url = url;
        }

        public string Url => _url;

        public string Topic
        {
            get => _topic;
            //set => _topic = value;
            set
            {
                _topic = value;
            }

        }

    }

    [Help("https://docs.microsoft.com/dotnet/csharp/tour-of-csharp/features")]
    public class AttributeTest
    {
        [Help("https://docs.microsoft.com/dotnet/csharp/tour-of-csharp/features", Topic = "DisPlay")]
        public void DisPlay(string text)
        {

        }
    }

}
