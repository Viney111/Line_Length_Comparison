using Line_Length_Comparison;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Length
{
    internal class Length
    {
        public static void Main(string[] args)
        {
            //PASSING ARGUMENTS
            LineLength L1 = new LineLength(2, 2, 5, 6);
            double line1Length = L1.CalculatingLength();

            LineLength L2 = new LineLength(10, 9, 5, 6);
            double line2Length = L2.CalculatingLength();

            int result = line1Length.CompareTo(line2Length);
            switch (result)
            {
                case 0:
                    Console.WriteLine("Two lines are equal");
                    break;
                case 1:
                    Console.WriteLine("Line 1 is greater than Line 2");
                    break;
                default:
                    Console.WriteLine("Line 2 is greater than Line 1");
                    break;
            }
        }
    }
}

