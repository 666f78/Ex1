using System;

namespace Ex1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Title = "Ex1";
            Console.WriteLine(String.Format("{0}", DateTime.Now));
            ColorLine color_line = new ColorLine();
            while (true)
            {
                Console.WriteLine("Enter Time(format hh.mm):");
                string HourMin = Console.ReadLine();
                color_line.Check(HourMin);
            }
        }
    }
}
