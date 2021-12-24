using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;
        private string v;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }
        public bool Value { get; set; }

        public Job()
        {
            Id = nextId++;
        }

        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency):this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public Job(string v)
        {
            this.v = v;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, EmployerName, EmployerLocation, JobType, JobCoreCompetency);
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id &&
                   Name == job.Name;
        }

        public override string ToString()
        {
            string dna = "Data Not Available";
            string nameTemp;
            if (Name == "" || Name == null)
            {
                nameTemp = dna;
            }
            else
            {
                nameTemp = Name;
            }

            string employerTemp;
            if (EmployerName.ToString() == "" || EmployerName.ToString() == null)
            {
                employerTemp = dna;
            }
            else
            {
                employerTemp = EmployerName.ToString();
            }

            string employerTempLocation;
            if (EmployerLocation.ToString() == "" || EmployerLocation.ToString() == null)
            {
                employerTempLocation = dna;
            }
            else
            {
                employerTempLocation = EmployerLocation.ToString();
            }
            string pt;
            if (JobType.ToString() == "" || JobType.ToString() == null)
            {
                pt = dna;
            }
            else
            {
                pt = JobType.ToString();
            }
            string cc;
            if (JobCoreCompetency.ToString() == "" || JobCoreCompetency.ToString() == null)
            {
                cc = dna;
            }
            else
            {
                cc = JobCoreCompetency.ToString();
            }


            return $"\nID: {Id}\n" +
                $"Name: {nameTemp}\n" +
                $"Employer: {employerTemp}\n" +
                $"Location: {employerTempLocation}\n" +
                $"Position Type: {pt}\n" +
                $"Core Compentency: {cc}\n"; 

        }
        //Name = (Name == "" || Name == null) ? Data Not Available : Name
        //b = (a == 1) ? 20 : 30;
        // TODO: Add the two necessary constructors.

        // TODO: Generate Equals() and GetHashCode() methods.
    }
}
