using System;

namespace Cats
{
    class Program
    {
        public static void Main(string[] args)
        {
            Cat catwoman = new HouseCat("catwoman", 13);

            (catwoman as HouseCat).IsSatisfied();
        }
    }
}
