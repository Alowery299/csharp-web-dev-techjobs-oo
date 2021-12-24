using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TestSettingJobId
{
    [TestClass]
    public class JobTests
    {
        //Job job1 = new Job();
        //Job job2 = new Job();

        [TestMethod]
        //[TestInitialize]
        public void Test01CreateJobObject()
        {

            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
            Assert.AreEqual(job1.Id + job2.Id, 3);
            Assert.IsTrue(job1.Id + job2.Id == 3);

        }

        [TestMethod]

        public void Test02TestJobsForEquality()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(job1.Id == job2.Id);

        }
        [TestMethod]

        public void Test03JobConstructorSetsAllFields()
        {

            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(job1.Name == "Product tester");
            Assert.IsTrue(job1.EmployerName.Value == "ACME");
            Assert.IsTrue(job1.EmployerLocation.Value == "Desert");
            Assert.IsTrue(job1.JobType.Value == "Quality control");
            Assert.IsTrue(job1.JobCoreCompetency.ToString() == "Persistence");

        }

        [TestMethod]

        public void Test04ToStringNewLineTest()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(job1.ToString().StartsWith("\n"));
            Assert.IsTrue(job1.ToString().EndsWith("\n"));
        }

        [TestMethod]

        public void Test05TestToStringConstructor()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string newLine = $"\nID: 7\n" +
                $"Name: Product tester\n" +
                $"Employer: ACME\n" +
                $"Location: Desert\n" +
                $"Position Type: Quality control\n" +
                $"Core Compentency: Persistence\n";
            Assert.AreEqual(newLine, job1.ToString());
        }
        [TestMethod]

        public void Test06TestToStringDataNotAvailable()
        {
            Job job1 = new Job("Product tester", new Employer(""), new Location(""), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            string newLine = $"\nID: 8\n" +
                $"Name: Product tester\n" +
                $"Employer: Data Not Available\n" +
                $"Location: Data Not Available\n" +
                $"Position Type: Quality control\n" +
                $"Core Compentency: Persistence\n";
            Assert.AreEqual(newLine, job1.ToString());
        }
        

    }   
    
}
