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

        public void Test02Equality()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.IsFalse(job1.Id == job2.Id);
           
        }
        [TestMethod]

        public void TestJobConstructorSetsAllFields()
        {

            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(job1.Name == "Product tester");
            Assert.IsTrue(job1.EmployerName.Value == "ACME");
            Assert.IsTrue(job1.EmployerLocation.Value == "Desert");
            Assert.IsTrue(job1.JobType.Value == "Quality control");
            //Assert.AreEqual(job1.JobCoreCompetency, "Persistence");
            
        }
        
        //    Job job3 = new Job("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));
        //    Assert.AreEqual(job1.Id, job3.Id);
        //}
        //[TestMethod]
        //public void JobIdIsDiffpublic void JobIdIsDiffer()erent()
        //{

        //    Job job2 = new Job("Web Developer", new Employer("LaunchCode"), new Location("St. Louis"), new PositionType("Front-end developer"), new CoreCompetency("JavaScript"));
        //    Job job3 = new Job("Ice cream tester", new Employer(""), new Location("Home"), new PositionType("UX"), new CoreCompetency("Tasting ability"));
        //    Assert.AreEqual(job2.Id, job3.Id);
        //}
        //[TestMethod]
        //public void TestJobConstructorSetsAllFields()
        //{
        //    Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        //       Assert.IsTrue(job.Value, job.Name);
        //}
        //[TestMethod]
        //public void TestJobConstructorSetsAllFieldslocation()
        //{
        //    Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        //    Assert.IsTrue(job.location, job.Location.value);
        //}
        //{
        //    Job job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        //    Assert.IsTrue(job1.Value, job1.Name);
    }
        //public void TestMethod()
        //{
        //    Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        //    Assert.IsTrue(job2.Value, job1.EmployerName);
        //}
    
}
