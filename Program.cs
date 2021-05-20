using System;

namespace POK_ZAD1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var cube1 = new CubeVolume(4);
            Console.WriteLine("Cube 1");
            Console.WriteLine(cube1.ToString());
            Console.ReadLine();

        }
    }
}
