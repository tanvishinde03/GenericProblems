using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblems
{
    public class FindMaxVal
    {
        public static int FindIntMaxVal(int First_val, int Second_val, int Third_val)
        {
            if (First_val.CompareTo(Second_val) > 0 && First_val.CompareTo(Third_val) > 0)
            {
                Console.WriteLine("First value is Greater :" + First_val);
                return First_val;
            }
            else if (Second_val.CompareTo(First_val) > 0 && Second_val.CompareTo(Third_val) > 0)
            {
                Console.WriteLine("Second value is Greater :" + Second_val);
                return Second_val;
            }
            else
            {
                Console.WriteLine("Third value is Greater :" + Third_val);
                return Third_val;

            }
        }
            public static void FindFloatMaxVal(double FirstNumber, double SecondNumber, double ThirdNumber)
            {
                if (FirstNumber.CompareTo(SecondNumber) >= 0 && FirstNumber.CompareTo(ThirdNumber) >= 0)
                {
                    Console.WriteLine("First Number Is Greater :" + FirstNumber);

                }
                else if (SecondNumber.CompareTo(FirstNumber) >= 0 && SecondNumber.CompareTo(ThirdNumber) >= 0)
                {
                    Console.WriteLine("Second Number Is Greater :" + SecondNumber);

                }
                else if (ThirdNumber.CompareTo(FirstNumber) >= 0 && ThirdNumber.CompareTo(SecondNumber) >= 0)
                {
                    Console.WriteLine("Third Number Is Greater :" + ThirdNumber);
                    Console.ReadLine();

                }
            }
        public static void FindStringMaxVal(string FirstValue, string SecondValue, String ThirdValue)
        {
            if (FirstValue.CompareTo(SecondValue) >= 0 && FirstValue.CompareTo(ThirdValue) >= 0)
            {
                Console.WriteLine("First Number Is Greater :" + FirstValue);

            }
            else if (SecondValue.CompareTo(FirstValue) >= 0 && SecondValue.CompareTo(ThirdValue) >= 0)
            {
                Console.WriteLine("Second Number Is Greater :" + SecondValue);

            }
            else if (ThirdValue.CompareTo(FirstValue) >= 0 && ThirdValue.CompareTo(SecondValue) >= 0)
            {
                Console.WriteLine("Third Number Is Greater :" + ThirdValue);
                Console.ReadLine();
            }
        }
        public T GenricValue<T>(T FirstValue, T SecondValue, T ThirdValue) where T : IComparable
        {
            if (FirstValue.CompareTo(SecondValue) > 0 && FirstValue.CompareTo(ThirdValue) > 0)
                return FirstValue;
            if (SecondValue.CompareTo(ThirdValue) > 0 && SecondValue.CompareTo(FirstValue) > 0)
                return SecondValue;
            if (ThirdValue.CompareTo(FirstValue) > 0 && ThirdValue.CompareTo(SecondValue) > 0)
                return ThirdValue;

            return FirstValue;
        }
    }
}
    
   

