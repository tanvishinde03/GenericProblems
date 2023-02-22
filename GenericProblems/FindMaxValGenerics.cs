using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblems
{
        public class FindMaxGenric<T> where T : IComparable
        {
            public T GenricValues(T FirstValue, T SecondValue, T ThirdValue)
            {
                if (FirstValue.CompareTo(SecondValue) > 0 && FirstValue.CompareTo(ThirdValue) > 0)
                    return FirstValue;
                else if (SecondValue.CompareTo(ThirdValue) > 0 && SecondValue.CompareTo(FirstValue) > 0)
                    return SecondValue;
                else
                    return ThirdValue;
               
            }


        }
    }
