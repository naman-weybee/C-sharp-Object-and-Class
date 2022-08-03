using System;

namespace Object_and_Class
{
    class Program
    {
        int id;     //field or data member
        string name;    //field or data member
        static void Main(string[] args)
        {
            Program obj = new Program();     // creating an object of Program
            obj.id = 5;
            obj.name = "jonny depp";
            Console.WriteLine(obj.id);
            Console.WriteLine(obj.name);
            Console.ReadLine();
        }
    }

    //public class Program
    //{
    //    public int id;
    //    public string name;
    //}
    //class newProgram
    //{
    //    static void Main(string[] args)
    //    {
    //        Program obj = new Program();
    //        obj.id = 5;
    //        obj.name = "jonny depp";
    //        Console.WriteLine(obj.id);
    //        Console.WriteLine(obj.name);
    //        Console.ReadLine();
    //    }
    //}

    //public class Program
    //{
    //    public int id;
    //    public string name;
    //    public void insert(int i, string n)
    //    {
    //        id = i;
    //        name = n;
    //    }
    //    public void display()
    //    {
    //        Console.WriteLine(id + " " + name);
    //    }
    //}
    //class newProgram
    //{
    //    static void Main(string[] args)
    //    {
    //        Program obj1 = new Program();
    //        Program obj2 = new Program();
    //        obj1.insert(10, "jonas");
    //        obj2.insert(20, "stive");
    //        obj1.display();
    //        obj2.display();
    //        Console.ReadLine();
    //    }
    //}

    //public class Employee
    //{
    //    public int id;
    //    public string name;
    //    public float salary;
    //    public void insert(int i, string n, float s)
    //    {
    //        id = i;
    //        name = n;
    //        salary = s;
    //    }
    //    public void display()
    //    {
    //        Console.WriteLine(id + " " + name + " " + salary);
    //    }
    //}
    //class newProgram
    //{
    //    static void Main(string[] args)
    //    {
    //        Employee obj1 = new Employee();
    //        Employee obj2 = new Employee();
    //        obj1.insert(10, "jonas", 70000f);
    //        obj2.insert(20, "stive", 85000f);
    //        obj1.display();
    //        obj2.display();
    //        Console.ReadLine();
    //    }
    //}
}
