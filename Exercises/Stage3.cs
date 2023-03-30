using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTes.Exercises
{
   public class Stage3
   {
      public void Main()
      {
         //Get the average salary of all jobs and display all the jobs that has a salary above the average and its weekly salary.
         //
         //Expected results:
         //Avergae = 21,000
         //Team Leader - Weekly salary: $7,500
         //Dev Sr - Weekly salary: $6,250
         //QA Tester Sr - Weekly salary: $5,750

         var data = GetData();
      }

      public static List<Job> GetData()
      {
         return new List<Job>() {
            new Job(){ ID = 1, MonthlySalary = 30000, Name = "Team Leader"},
            new Job(){ ID = 2, MonthlySalary = 25000, Name = "Dev Sr."},
            new Job(){ ID = 3, MonthlySalary = 15000, Name = "Dev Jr."},
            new Job(){ ID = 4, MonthlySalary = 23000, Name = "QA Tester Sr."},
            new Job(){ ID = 5, MonthlySalary = 12000, Name = "QA Tester Jr."},
         };
      }

      public class Job
      {
         public int ID { get; set; }
         public decimal MonthlySalary { get; set; }
         public string Name { get; set; }
      }
   }
}
