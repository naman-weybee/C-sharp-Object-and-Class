using System;

namespace EnumExample
{
    class Program
    {
        public enum Season { Winter, Spring, Summer, Fall };
        static void Main(string[] args)
        {
            int w = (int)Season.Winter;
            int x = (int)Season.Spring;
            int y = (int)Season.Summer;
            int z = (int)Season.Fall;
            Console.WriteLine("Winter: " + w);
            Console.WriteLine("Spring: " + x);
            Console.WriteLine("Summer: " + y);
            Console.WriteLine("Fall: " + z);
            Console.ReadLine();
        }
    }

    //class Program
    //{
    //    public enum Season { Winter = 5, Spring, Summer, Fall };
    //    static void Main(string[] args)
    //    {
    //        int w = (int)Season.Winter;
    //        int x = (int)Season.Spring;
    //        int y = (int)Season.Summer;
    //        int z = (int)Season.Fall;
    //        Console.WriteLine("Winter: " + w);
    //        Console.WriteLine("Spring: " + x);
    //        Console.WriteLine("Summer: " + y);
    //        Console.WriteLine("Fall: " + z);
    //        Console.ReadLine();
    //    }
    //}

    //class Program
    //{
    //    public enum Season { Winter, Spring, Summer = 8, Fall };
    //    static void Main(string[] args)
    //    {
    //        int w = (int)Season.Winter;
    //        int x = (int)Season.Spring;
    //        int y = (int)Season.Summer;
    //        int z = (int)Season.Fall;
    //        Console.WriteLine("Winter: " + w);
    //        Console.WriteLine("Spring: " + x);
    //        Console.WriteLine("Summer: " + y);
    //        Console.WriteLine("Fall: " + z);
    //        Console.ReadLine();
    //    }
    //}

    //class Program
    //{
    //    public enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
    //    static void Main(string[] args)
    //    {
    //        int w = (int)Days.Sun;
    //        int x = (int)Days.Mon;
    //        int y = (int)Days.Fri;
    //        int z = (int)Days.Sat;
    //        Console.WriteLine("Sun: " + w);
    //        Console.WriteLine("Mon: " + x);
    //        Console.WriteLine("Fri: " + y);
    //        Console.WriteLine("Sat: " + z);
    //        Console.ReadLine();
    //    }
    //}

    //public class Program
    //{
    //    public enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
    //    public static void Main(string[] args)
    //    {
    //        foreach (string s in Enum.GetNames(typeof(Days)))
    //        {
    //            Console.WriteLine(s);
    //        }
    //        Console.ReadLine();
    //    }
    //}

    //public class Program
    //{
    //    public enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
    //    public static void Main(string[] args)
    //    {
    //        foreach (Days s in Enum.GetValues(typeof(Days)))
    //        {
    //            Console.WriteLine(s);
    //        }
    //        Console.ReadLine();
    //    }
    //}
}
