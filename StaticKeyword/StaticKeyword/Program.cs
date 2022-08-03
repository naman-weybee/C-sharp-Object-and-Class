using System;

namespace StaticKeyword
{
    //public class Program
    //{
    //    public int accNo;
    //    public string name;
    //    public float salary;
    //    public static float Rate = 3.34f;
    //    public Program(int i, string n, float s)
    //    {
    //        this.accNo = i;
    //        this.name = n;
    //        this.salary = s;
    //    }
    //    public void display()
    //    {
    //        Console.WriteLine(accNo + " " + name + " " + salary + " " + Rate);
    //    }
    //}
    //class NewProgram
    //{
    //    static void Main(string[] args)
    //    {
    //        Program obj1 = new Program(100, "devy jons", 56000f);
    //        Program obj2 = new Program(101, "jonny depp", 76000f);
    //        obj1.display();
    //        obj2.display();
    //        Console.ReadLine();
    //    }
    //}

    public class Program
    {
        public int accNo;
        public string name;
        public float salary;
        public static float Rate = 3.34f;
        public static int count = 0;
        public Program(int accNo, string name, float salary)
        {
            this.accNo = accNo;
            this.name = name;
            this.salary = salary;
            count++;
        }
        public void display()
        {
            Console.WriteLine(accNo + " " + name + " " + salary + " " + Rate);
        }
    }
    class NewProgram
    {
        static void Main(string[] args)
        {
            Program.Rate = 10.5f;
            Program obj1 = new Program(16, "Gautam Joshi", 78000f);
            Program obj2 = new Program(17, "Ayush Savaliya", 82000f);
            Program obj3 = new Program(18, "Kahan Gotecha", 89000f);
            obj1.display();
            obj2.display();
            obj3.display();
            Console.WriteLine("Rate: " + Program.Rate);
            Console.WriteLine("Total Objects: " + Program.count);
            Console.ReadLine();
        }
    }
}
