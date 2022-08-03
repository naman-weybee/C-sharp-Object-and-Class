using System;

namespace Destructor
{
    public class Program
    {
        public Program()
        {
            Console.WriteLine("Constructor...!");
        }
        ~Program()
        {
            Console.WriteLine("Destructor...!");
        }
    }
    class NewProgram
    {
        static void Main(string[] args)
        {
            Program obj1 = new Program();
            Program obj2 = new Program();
            Console.ReadLine();
        }
    }
}
