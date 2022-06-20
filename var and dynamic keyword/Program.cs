using System;

namespace var_and_dynamic_keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 2;
            //x = "KETKI";

            var y = "KETKI";
            //y = 1;
            dynamic x1 = 2;
            x1 = "KETKI";
            Console.WriteLine(x);
            Console.WriteLine(x1);
        }
    }
}
