namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void Test_Min()
        {
            var employee = new Employee("Weber", "Webow");
            employee.AddGrade(4);
            employee.AddGrade(7);
            employee.AddGrade(6);
            var statistics = employee.GetStatistics();

            Assert.AreEqual(4, statistics.Min);
        }

        [Test]
        public void Test_Max()
        {
            var employee = new Employee("Weber", "Webow");
            employee.AddGrade(4);
            employee.AddGrade(10);
            employee.AddGrade(8);
            var statistics = employee.GetStatistics();

            Assert.AreEqual(10, statistics.Max);
        }

        [Test]
        public void StatisticsTestAverage()
        {
            var employee = new Employee("Weber", "Webow");
            employee.AddGrade(2);
            employee.AddGrade(5);
            employee.AddGrade(4);
            var statistics = employee.GetStatistics();

            Assert.AreEqual(Math.Round(3.67, 2), Math.Round(statistics.Average, 2));
        }
    }
}