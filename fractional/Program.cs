using System;

namespace fractional
{
    class program
    {
        public void fractionals()
        {
            double value = 7.5;
            int whole = 9;
            double fractional = 8.0;
            Console.WriteLine(value);

            fractional = value - whole;
            Console.WriteLine(whole);
            Console.WriteLine(fractional);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program obj = new Program();
            obj.fractional();
            Console.ReadLine();
        }
    }
}

