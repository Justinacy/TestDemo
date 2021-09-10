using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo.TestClass
{
    /// <summary>
    ///AsyncAwaitTest示例
    /// </summary>
    public class AsyncAwaitTest
    {
        public async Task<int> AsyncTest()
        {
            var client = new HttpClient();

            var result = await client.GetByteArrayAsync("http://baidu.com");

            return result.Length;
        }
    }
}
