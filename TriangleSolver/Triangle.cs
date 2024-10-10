using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSolver
{
    public static class Triangle
    {
        public static string AnalyzeTriangle(int firstSide, int secondSide, int thirdSide)
        {
            string output;
            if ((firstSide == 0) || (secondSide == 0) || (thirdSide == 0))
            {
                output = "INVALID triangle - a zero was entered";
                return output;
            }

                if (((firstSide + secondSide) > thirdSide) && ((firstSide + thirdSide) > secondSide) && ((secondSide + thirdSide) > firstSide))
                {
                    if ((firstSide == secondSide) && (firstSide == thirdSide) && (secondSide == thirdSide))
                    {
                        output = "A triangle is formed and it is an EQUILATERAL";
                    }
                    else if ((firstSide == secondSide) || (secondSide == thirdSide) || (thirdSide == firstSide))
                    {
                        output = "A triangle is formed and it is an ISOSCELES";

                    }
                    else
                    {
                        output = "A triangle is formed and it is a SCALENE";

                    }


                }
                else
                {
                    output = "A triangle is not formed based on the input values";
                }

            
            return output;
        }
    }
}
