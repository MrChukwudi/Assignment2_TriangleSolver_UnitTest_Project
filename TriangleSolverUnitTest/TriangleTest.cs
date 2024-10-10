using NUnit.Framework.Legacy;
using NUnit.Framework;
using TriangleSolver;

namespace TriangleSolverUnitTest
{
    [TestFixture] //Annotation to indicate a Unit Test Class: Used to mark any class that will contain Unit tests
  
        public class TriangleTests
        {
            // 1. Valid equilateral triangle test
            [Test]
            [TestCase(3, 3, 3, ExpectedResult = "A triangle is formed and it is an EQUILATERAL")]
            public string AnalyzeTriangle_ValidEquilateralTriangle_Test(int firstSide, int secondSide, int thirdSide)
            {
                return Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
            }





        // 2. Valid isosceles triangle tests
        [Test]
        [TestCase(5, 5, 8, ExpectedResult = "A triangle is formed and it is an ISOSCELES")]
        [TestCase(6, 6, 4, ExpectedResult = "A triangle is formed and it is an ISOSCELES")]
        [TestCase(7, 7, 10, ExpectedResult = "A triangle is formed and it is an ISOSCELES")]
        public string AnalyzeTriangle_ValidIsoscelesTriangle_Test(int firstSide, int secondSide, int thirdSide)
        {
            return Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
        }


        // 3. Valid scalene triangle tests
        [Test]
        [TestCase(3, 4, 5, ExpectedResult = "A triangle is formed and it is a SCALENE")]
        [TestCase(7, 5, 10, ExpectedResult = "A triangle is formed and it is a SCALENE")]
        [TestCase(6, 8, 9, ExpectedResult = "A triangle is formed and it is a SCALENE")]
        [TestCase(9, 11, 15, ExpectedResult = "A triangle is formed and it is a SCALENE")]
        [TestCase(12, 14, 18, ExpectedResult = "A triangle is formed and it is a SCALENE")]
        public string AnalyzeTriangle_ValidScaleneTriangle_Test(int firstSide, int secondSide, int thirdSide)
        {
            return Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
        }

    }
    

}
