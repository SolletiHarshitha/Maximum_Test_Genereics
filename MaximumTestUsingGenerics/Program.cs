using System;

namespace MaximumTestUsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Among Three");
            MaximumAmongThree max = new MaximumAmongThree();
            float result = max.FindMaxValueOfFloat(10.5f, 20.5f, 30.5f);
            Console.WriteLine("Maximum value is : "+result);
            
        }
    }
}
