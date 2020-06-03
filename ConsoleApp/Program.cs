using EntityFramework;
using NinjaDomain.DataModel;
using System;
using System.Data.Entity;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new NullDatabaseInitializer<NinjaContext>());
            InsertNinja();
        }
        private static void InsertNinja()
        {
            var ninja = new Ninja
            {
                Name = "JulieSan",
                ServedInOniwaban = false,
                DateOfBirth = new DateTime(2008, 1, 28),
                ClanId = 1

            };
            using (var context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Ninjas.Add(ninja);
                context.SaveChanges();
            }


        }
    }
}
