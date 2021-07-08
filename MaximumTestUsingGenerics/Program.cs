using System;

namespace MaximumTestUsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Among Three");
            MaximumAmongThree max = new MaximumAmongThree();
            int result = max.FindMaxValue(10, 20, 30);
            Console.WriteLine("Maximum value is : "+result);
        }
    }
}
