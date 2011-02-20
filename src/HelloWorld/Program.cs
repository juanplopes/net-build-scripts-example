using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new MessageBuilder();
            Console.WriteLine(builder.Build());
        }
    }
}
