using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Learning_Csharp
{
    public class myClass
    {
        public struct MyStruct
        {
            public static int x = 100;
            public static string prompt = "Please type your name followed by the ENTER key.";
            public static string name;
            public static bool IsKeyDown = false;
           
        }
    }

   
    class Program
    {
        static void Main(string[] args)
        {
            MyClass practiceName = new MyClass();

           Console.Write(practiceName.Multi(45, 67));
            
            

            //Console.WriteLine(myClass.MyStruct.prompt);
            myClass.MyStruct.name = Console.ReadLine();

            Console.WriteLine("Hello " + myClass.MyStruct.name);
            
            
           


            while (true);
        }
    }
}
