using System;

namespace Static_Class
{
    public static class Program
    {
        public static float pi = 3.14f;
        public static int Cube(int n)
        {
            return n * n * n;
        }
    }
    class NewProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.pi);
            Console.WriteLine(Program.Cube(5));
            Console.ReadLine();
        }
    }
}
