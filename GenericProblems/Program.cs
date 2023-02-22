using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose Number");
            Console.WriteLine("Enter 1:Finding Maximum Int Numbers ");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FindMaxVal.FindIntMaxVal(3, 5, 1);
                    break;
            }
            Console.ReadLine();
        }
    }
}
