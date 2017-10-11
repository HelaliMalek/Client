using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLientWebservice
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new LemonWayService.WebServiceSoapClient())
            {
                var fabSuite = client.Fibonacci(10);
                Console.WriteLine(fabSuite);
            }

            for (;;) { }

        }
    }
}
