using System;

namespace Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie1 = new Cookie(15, "sqaure");
            var cookie2 = new Cookie(14, "triangle");
            var cookie3 = new Cookie(13, "circle");
            var cookie4 = new Cookie(12, "sphere");

            var red = new Colour("rgb(255,0,0)");
            var blue = new Colour("rgb(0,0,255)");
            var green = new Colour("rgb(0,128,0)");
            
            Console.WriteLine(cookie1 + " " + red);
            
        }
    }
}
