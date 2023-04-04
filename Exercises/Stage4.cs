using System;
using System.Collections.Generic;
using System.Linq;

namespace DevTes.Exercises
{
   public class Stage3
   {
      static void Main(string[] args)
      {
         var medicineData = GetMedicineData();
         var costData = GetCostData();

         // 1.-Get all medicine that is already expired before today. 
         // 
         // Expected result:
         // Acetaminophen
         // Ibuprofen
         // Ketorolac Acid
         // Thiamazole Acid
         // Terramicin Acid

         // 2.-Get all the medicines that can be sold even if they are expired.
         // The medicines "B" are allow to be sold when expired if expiration date is less than 12 months.
         //
         // Expected result:
         // Aspirin
         // Ambroxol Acid
         // Terramicin Acid

         // 3.-Get the Name and most recent price for each medicine. 
         // Fix the code written in lines 43 to 45
         //
         // Expected results:
         // Acetaminophen - $61.06
         // Ibuprofen - $7.99
         // Aspirin - $35.13
         // Ketorolac Acid - $25.56
         // Thiamazole Acid - $40.50
         // Ambroxol Acid - $42.12
         // Terramicin Acid - $51.12

         var inventory = costData.Where(r => r.EffectiveDate <= DateTime.Today)
                           .Select(r => new { ID = r.MedicineID, CurrentValue = r.Cost })
                           .OrderBy(r => r.ID);
      }

      public static List<Medicine> GetMedicineData()
      {
         return new List<Medicine>() {
         new Medicine(){ ID = 1, Name = "Acetaminophen", ExpirationDate = new DateTime(2020,05,01), Type = MedicineType.A},
         new Medicine(){ ID = 2, Name = "Ibuprofen", ExpirationDate = new DateTime(2014,02,07), Type = MedicineType.A},
         new Medicine(){ ID = 3, Name = "Aspirin", ExpirationDate = new DateTime(2027,03,21), Type = MedicineType.B},
         new Medicine(){ ID = 4, Name = "Ketorolac Acid", ExpirationDate = new DateTime(2021,04,01), Type = MedicineType.A},
         new Medicine(){ ID = 5, Name = "Thiamazole Acid", ExpirationDate = new DateTime(2019,11,30), Type = MedicineType.B},
         new Medicine(){ ID = 6, Name = "Ambroxol Acid", ExpirationDate = new DateTime(2023,12,06), Type = MedicineType.B},
         new Medicine(){ ID = 7, Name = "Terramicin Acid", ExpirationDate = new DateTime(2022,12,06), Type = MedicineType.B}
       };
      }

      public static List<MedicineCost> GetCostData()
      {
         return new List<MedicineCost>() {
            new MedicineCost(){ID = 1, MedicineID = 1, Cost = 13.12m, EffectiveDate = new DateTime(2020,03,01)},
            new MedicineCost(){ID = 2, MedicineID = 4, Cost = 25.56m, EffectiveDate = new DateTime(2019,05,27)},
            new MedicineCost(){ID = 3, MedicineID = 3, Cost = 35.13m, EffectiveDate = new DateTime(2021,03,25)},
            new MedicineCost(){ID = 4, MedicineID = 6, Cost = 13.56m, EffectiveDate = new DateTime(2020,07,09)},
            new MedicineCost(){ID = 5, MedicineID = 2, Cost = 103.99m, EffectiveDate = new DateTime(2022,03,25)},
            new MedicineCost(){ID = 6, MedicineID = 1, Cost = 61.06m, EffectiveDate = new DateTime(2021,12,15)},
            new MedicineCost(){ID = 7, MedicineID = 5, Cost = 40.50m, EffectiveDate = new DateTime(2022,03,07)},
            new MedicineCost(){ID = 8, MedicineID = 2, Cost = 7.99m, EffectiveDate = new DateTime(2023,03,24)},
            new MedicineCost(){ID = 9, MedicineID = 6, Cost = 42.12m, EffectiveDate = new DateTime(2021,03,19)},
            new MedicineCost(){ID = 10, MedicineID = 7, Cost = 51.12m, EffectiveDate = new DateTime(2021,03,19)},
            new MedicineCost(){ID = 11, MedicineID = 6, Cost = 13.99m, EffectiveDate = new DateTime(2019,01,01)}
         };
      }

      public class Medicine
      {
         public int ID { get; set; }
         public string Name { get; set; }
         public DateTime ExpirationDate { get; set; }
         public MedicineType Type { get; set; }
      }

      public class MedicineCost
      {
         public int ID { get; set; }
         public int MedicineID { get; set; }
         public decimal Cost { get; set; }
         public DateTime EffectiveDate { get; set; }
      }

      public enum MedicineType : int
      {
         NotSet = 0,
         A = 1,
         B = 2
      }
   }
}
