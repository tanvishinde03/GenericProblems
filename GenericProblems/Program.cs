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
            Console.WriteLine("Enter 2:Finding Double Number");
            Console.WriteLine("Enter 3:Finding String Value");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FindMaxVal.FindIntMaxVal(3, 5, 1);
                    break;
                case 2:
                    FindMaxVal.FindFloatMaxVal(12.2, 23.4, 45.6);
                    break;
                case 3:
                    FindMaxVal.FindStringMaxVal("Indore", "Bhopal", "Ujjain");
                    break;

            }
            Console.ReadLine();
        }
    }
}
