using System;

namespace ThisKeyword
{
    public class Program
    {
        public int id;
        public string name;
        public float salary;
        public Program(int i, string n, float s)
        {
            this.id = i;
            this.name = n;
            this.salary = s;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
    }
    class NewProgram
    {
        static void Main(string[] args)
        {
            Program obj1 = new Program(100, "devy jons", 56000f);
            Program obj2 = new Program(101, "jonny depp", 76000f);
            obj1.display();
            obj2.display();
            Console.ReadLine();
        }
    }
}
