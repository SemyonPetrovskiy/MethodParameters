using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodParametersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // передача параметров (аргументов) в с# 2-мя способами:
            // 1. по значению
            // 2. по ссылке
            // out - модификатор позволяющий определить выходной параметр

            int d1 = Optional(1, 2, 3, 4);
            int d2 = Optional(1, 2, 3);
            int d3 = Optional(1, 2);
            Console.WriteLine($"d1 {d1}");

            int perimeter;
            int area;
            GetData(10, 15, out area, out perimeter);
            Console.WriteLine($"area {area}");
            Console.WriteLine($"perimeter {perimeter}");

            int z = 5;
            int d = 6;
            Console.WriteLine($"Initialvalue z = {z}");
            AdditionVal(z, d);
            Console.WriteLine($"After AdditionVal z = {z}");
            AdditionRef(ref z, d);
            Console.WriteLine($"After AdditionRef z = {z}");


            int c = Sum(z, 15);   // по значению
            Console.WriteLine(c); // 25
            Console.ReadKey();
        }

        // именованные параметры  int d1 = Optional(s:1, y:2, z:3, x:4);


        // необязательные параметры
        static int Optional(int x, int y, int z = 5, int s = 7) // следующие за необязательными *
                                                                // * параметрами значения должны быть такими же
        {
            return x + y + z + s;
        }

        static void GetData(int width, int height, out int area, out int perimeter)
        {
            perimeter = (width + height) * 2;
            area = width * height;
        }

        static void AdditionRef(ref int x, int y) // модификатор ref передает параметры по ссылке
        {
            x = x + y;
            Console.WriteLine($"AdditionRef x = {x}");

        }

        static void AdditionVal(int x, int y) // метод передает параметры по значению
        {
            x = x + y;
            Console.WriteLine($"AdditionVal x = {x}");
        }

        static string Hello()
        {
            return "hello world!";
        }

        static int Sum(int x, int y)
        {
            return x + y; 
        }
    }
}
