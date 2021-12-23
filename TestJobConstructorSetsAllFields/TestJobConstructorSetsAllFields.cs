using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TestJobConstructorSetsAllFields
{
    [TestClass]
    public class TestJobConstructorSetsAllFields
    {
        [TestMethod]
        public void TestMethod1()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(job1.Value, job1.EmployerName)
        }


    }
}
