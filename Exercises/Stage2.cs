using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTes.Exercises
{
   public class Stage2
   {
      public void Main()
      {
         //Display all the sick chicks and how many chicks are not sick.
         //
         //Expected results:
         //Hernesto
         //Jaimico
         //Laura
         //Healthy chicks: 3
         
         //Display all the chicks sort by Name.
         //Expected resutls:
         //Hernesto
         //Jaimico
         //Juan
         //Laura
         //Lucia
         
         var data = GetData();
      }

      public static List<Chicken> GetData()
      {
         return new List<Chicken>() {
            new Chicken(){ ID = 1, Name = "Juan", IsSick= false},
            new Chicken(){ ID = 2, Name = "Hernesto", IsSick= true},
            new Chicken(){ ID = 3, Name = "Lucia", IsSick= false},
            new Chicken(){ ID = 4, Name = "Jaimico", IsSick= true},
            new Chicken(){ ID = 5, Name = "Laura", IsSick= true}
         };
      }

      public class Chicken
      {
         public int ID { get; set; }
         public string Name { get; set; }
         public bool IsSick { get; set; }
      }
   }
}
