using System;

namespace p1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Cir = new circle();
            float g = Cir.GetRadius(4);
            Cir.Area();
            Cir.Circumference();
        }
    }
}
