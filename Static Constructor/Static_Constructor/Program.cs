using System;

namespace Static_Constructor
{
    public class Program
    {
        public int id;
        public string name;
        public static float Rate;

        public Program(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        static Program()
        {
            Rate = 7.5f;
            Console.WriteLine("Static Constructor Always called one time and execute first...!");
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + Rate);
        }
    }
    class NewProgram
    {
        static void Main(string[] args)
        {
            Program obj1 = new Program(101, "ayush savaliya");
            Program obj2 = new Program(102, "gautam joshi");
            obj1.display();
            obj2.display();
            Console.ReadLine();
        }
    }
}
