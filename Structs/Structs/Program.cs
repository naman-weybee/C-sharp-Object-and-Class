using System;

namespace Structs
{
    public struct Program
    {
        public int width, height;
    }
    class NewProgram
    {
        static void Main(string[] args)
        {
            //Program rec = new Program();
            Program rec;        // Struct can create an instance, with or without new keyword.
            rec.width = 25;
            rec.height = 10;
            Console.WriteLine("Area of rectangel is: " + rec.width * rec.height);
            Console.ReadLine();
        }
    }

    //public struct Program
    //{
    //    public int width, height;

    //    public Program(int width, int height)
    //    {
    //        this.width = width;
    //        this.height = height;
    //    }
    //    public void display()
    //    {
    //        Console.WriteLine("Area of rectangel is: " + width * height);
    //    }
    //}
    //class NewProgram
    //{
    //    static void Main(string[] args)
    //    {
    //        Program rec = new Program(10,5);
    //        rec.display();
    //        Console.ReadLine();
    //    }
    //}
}