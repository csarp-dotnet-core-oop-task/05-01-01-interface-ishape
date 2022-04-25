using System;

using GeometriaiAlakzatokProjekt.Model;

namespace GeometriaiAlakzatokProjekt
{

   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Circle c = new Circle(3);
            Console.WriteLine("Terület:"+c.Area());
            Square s = new Square(3);
            Console.WriteLine("Terület:"+s.Area());
        }
    }
}
