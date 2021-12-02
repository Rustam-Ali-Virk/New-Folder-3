using System;

namespace p2
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new mark();
            result.Subject_1 = 43;
            result.Subject_2 = 40;
            result.Subject_3 = 41;
            result.Sum();
            result.Average();
        }
    }
}
