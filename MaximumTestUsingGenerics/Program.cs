using System;

namespace MaximumTestUsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maximum Among Three");
            MaximumAmongThree max = new MaximumAmongThree();
            string result = max.FindMaxValueOfString("Apple","Peach","Banana");
            Console.WriteLine("Maximum value is : "+result);
            
        }
    }
}
