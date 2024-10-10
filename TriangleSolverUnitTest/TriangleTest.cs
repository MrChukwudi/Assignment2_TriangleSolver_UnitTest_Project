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


        // 4. Zero side length tests
        [Test]
        [TestCase(0, 5, 6, ExpectedResult = "INVALID triangle - a zero was entered")]
        [TestCase(5, 0, 6, ExpectedResult = "INVALID triangle - a zero was entered")]
        [TestCase(5, 6, 0, ExpectedResult = "INVALID triangle - a zero was entered")]
        public string AnalyzeTriangle_ZeroSideLength_Test(int firstSide, int secondSide, int thirdSide)
        {
            return Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
        }

        // 5. Invalid triangle tests (not forming a triangle, but no zero side)
        [Test]
        [TestCase(2, 2, 5, ExpectedResult = "A triangle is not formed based on the input values")]
        [TestCase(10, 3, 5, ExpectedResult = "A triangle is not formed based on the input values")]
        [TestCase(1, 5, 10, ExpectedResult = "A triangle is not formed based on the input values")]
        public string AnalyzeTriangle_InvalidTriangle_Test(int firstSide, int secondSide, int thirdSide)
        {
            return Triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);
        }

    }
    

}
