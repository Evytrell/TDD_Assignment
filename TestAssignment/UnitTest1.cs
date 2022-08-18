using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_Assignment;

namespace TestAssignment

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod()]

        [DataRow("15", "8", "60")]
        [DataRow("20", "12", "120")]
        [DataRow("30", "7", "105")]

        public void AreaOfTrapeziumTest(string lengthString, string heightString, string expectedResultString)
        {
            // multiple test cases

            var length = double.Parse(lengthString);
            var height= double.Parse(heightString);
            var expectedResult = double.Parse(expectedResultString);

            var shape = new Shapes();
            double area = shape.AreaOfTrapezium(length, height);
            Assert.AreEqual(expectedResult, area);


            // single test case
           // var shape = new Shapes();
           // double area = shape.AreaOfTrapezium(15, 8);
          //  Assert.AreEqual(60, area);

        }
    }
}
