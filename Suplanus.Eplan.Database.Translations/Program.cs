using System;

namespace Suplanus.Eplan.Database.Translations
{
   class Program
   {
      static void Main(string[] args)
      {
         using (TranslationEntities translationEntities = new TranslationEntities())
         {
            Console.WriteLine("{0}\t{1}", "German", "English");
            Console.WriteLine("-----------------");
            foreach (var translation in translationEntities.Translations)
            {
               Console.WriteLine("{0}\t{1}", translation.de_DE_Match, translation.en_US_Match);
            }
         }

         Console.ReadKey();
      }
   }
}
