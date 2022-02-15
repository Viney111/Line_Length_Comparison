using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Length_Comparison
{
    public class LineLength
    {
        int x1;
        int x2;
        int y1;
        int y2;

        public LineLength(int x1,int y1, int x2, int y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }
        public double CalculatingLength()
        {
            double lengthOfLine = Math.Pow(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2), 0.5);
            return lengthOfLine;
        }
    }
}
