using System;

namespace Suplanus.Eplan.Database.ProjectManagement
{
   class Program
   {
      static void Main(string[] args)
      {
         using (ProjectEntities projectEntities = new ProjectEntities())
         {
            foreach (var project in projectEntities.Projects)
            {
               Console.WriteLine(project.Project_Name);
            }
         }

         Console.ReadKey();
      }
   }
}
