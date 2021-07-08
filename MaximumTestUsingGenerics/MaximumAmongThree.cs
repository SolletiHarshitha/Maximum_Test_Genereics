﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumTestUsingGenerics
{
    public class MaximumAmongThree
    {
        public int FindMaxValueOfInt(int first,int second,int third)
        {
            if(first.CompareTo(second) > 0 && first.CompareTo(second) > 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            else
            {
                Console.WriteLine("All three values are equal");
                return 0;
            }
        }

        public float FindMaxValueOfFloat(float first, float second, float third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(second) > 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            else
            {
                Console.WriteLine("All three values are equal");
                return 0;
            }
        }

        public string FindMaxValueOfString(string first, string second, string third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(second) > 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                return third;
            }
            else
            {
                Console.WriteLine("All three values are equal");
                return null;
            }
        }
    }
}
