using System;

namespace Constructor
{
    class Constructor
    {
        public Constructor()
        {
            Console.WriteLine("User Defined Constructor...!");
        }
        static void Main(string[] args)
        {
            Constructor obj1 = new Constructor();
            Constructor obj2 = new Constructor();
            Console.ReadLine();
        }
    }

    //public class Program
    //{
    //    public Program()
    //    {
    //        Console.WriteLine("User Defined Constructor...!");
    //    }
    //}
    //class NewProgram
    //{
    //    static void Main(string[] args)
    //    {
    //        Program obj1 = new Program();
    //        Program obj2 = new Program();
    //        Console.ReadLine();
    //    }
    //}

    //public class Program
    //{
    //    public int id;
    //    public string name;
    //    public float salary;
    //    public Program(int i, string n, float s)
    //    {
    //        //Console.WriteLine("Parameterized Constructor...!");
    //        id = i;
    //        name = n;
    //        salary = s;
    //    }
    //    public void display()
    //    {
    //        Console.WriteLine(id + " " + name + " " + salary);
    //    }
    //}
    //class NewProgram
    //{
    //    static void Main(string[] args)
    //    {
    //        Program obj1 = new Program(10, "jack sparrow", 50000f);
    //        Program obj2 = new Program(11, "devy jons", 70000f);
    //        obj1.display();
    //        obj2.display();
    //        Console.ReadLine();
    //    }
    //}
}
