using System;

namespace vn_mode_csharp_dz10
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingNumber = 5;
            int endNumber = 96;
            int ourStep = 7;

            for (int i = startingNumber; i <= endNumber; i += ourStep)
            {
                Console.WriteLine(i);
            }
        }
    }
}
