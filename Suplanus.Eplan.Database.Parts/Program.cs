using System;

namespace Suplanus.Eplan.Database.Parts
{
   class Program
   {
      static void Main(string[] args)
      {
         using (PartsEntities partsEntities = new PartsEntities())
         {
            foreach (var part in partsEntities.Parts)
            {
               Console.WriteLine(part.partnr);
            }
         }

         Console.ReadKey();
      }
   }
}
