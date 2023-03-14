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
         //Get the average salary of all jobs and display all the jobs that has a salary above the average.
         //
         //Expected results:
         //Avergae = 21,000
         //Team Leader 
         //Dev Sr. 
         //QA Tester Sr.

         var data = GetData();
      }

      public static List<Job> GetData()
      {
         return new List<Job>() {
            new Job(){ ID = 1, Salary = 30000, Name = "Team Leader"},
            new Job(){ ID = 2, Salary = 25000, Name = "Dev Sr."},
            new Job(){ ID = 3, Salary = 15000, Name = "Dev Jr."},
            new Job(){ ID = 4, Salary = 23000, Name = "QA Tester Sr."},
            new Job(){ ID = 5, Salary = 12000, Name = "QA Tester Jr."},
         };
      }

      public class Job
      {
         public int ID { get; set; }
         public decimal Salary { get; set; }
         public string Name { get; set; }
      }
   }
}
