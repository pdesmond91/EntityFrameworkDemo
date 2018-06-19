using EF6Domain.Classes;
using EF6Domain.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {


            QueryGeCustomer();
            //Database.SetInitializer(new NullDatabaseInitializer<NinjaContext>());
            //InsertNinja();
            //InsertMultipleNinjas();
            //InsertNinjaWithEquipment();
            //SimpleNinjaQuery();
            //SimpleNinjaGraphQuery();
            //QueryAndUpdateNinja();
            //QueryAndUpdateNinjaDisconnected();
            //DeleteNinja();
            DeleteNinjaDisconnected();
            //RetrieveDataWithFind();
            //Console.ReadKey();
        }

        private static void DeleteNinjaDisconnected()
        {
            Ninja ninja;
            using (var context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                ninja = context.Ninjas.FirstOrDefault();
            }
            using (var context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Entry(ninja).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        private static void QueryGeCustomer()
        {
            using (var context = new GeDbContext())
            {
                var cust = context.CUSTOMER.Where(n => n.CUSTOMER_ID == "PREBON").FirstOrDefault();
                Console.WriteLine("Customer Found: " + cust.CUSTOMER_ID);
            }
        }

        private static void RetrieveDataWithFind()
        {
            var keyVal = 3;
            using(var context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                var ninja = context.Ninjas.Find(keyVal);
                Console.WriteLine("After Find #1 " + ninja.Name);

                var ninjaAgain = context.Ninjas.Find(keyVal);
                Console.WriteLine("After Find #2 " + ninjaAgain.Name);
            }
        }

        private static void DeleteNinja()
        {
            using (var context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                var ninja = context.Ninjas.FirstOrDefault();
                context.Ninjas.Remove(ninja);
                context.SaveChanges();
            }
        }

        private static void QueryAndUpdateNinjaDisconnected()
        {
            Ninja ninja;
            using (var context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                ninja = context.Ninjas.FirstOrDefault();
            }

            ninja.ServedInOniwaban = (!ninja.ServedInOniwaban);

            using (var context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Ninjas.Attach(ninja);
                context.Entry(ninja).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        

        private static void QueryAndUpdateNinja()
        {
            using(var context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                var ninja = context.Ninjas.FirstOrDefault();
                ninja.ServedInOniwaban = (!ninja.ServedInOniwaban);
                context.SaveChanges();
            }
        }

        private static void SimpleNinjaGraphQuery()
        {
            throw new NotImplementedException();
        }

        private static void SimpleNinjaQuery()
        {
            using (var context = new NinjaContext())
            {
                var ninjas = context.Ninjas.OrderBy(n => n.Name)
                    .Skip(1).Take(2).ToList();

                foreach (var ninja in ninjas)
                {
                    Console.WriteLine(ninja.Name);
                }
            }
        }

        private static void InsertNinjaWithEquipment()
        {
            throw new NotImplementedException();
        }

        private static void InsertMultipleNinjas()
        {
            var ninja1 = new Ninja
            {
                Name = "Raphael",
                ServedInOniwaban = false,
                DateofBirth = new DateTime(1984, 02, 20),
                ClanId = 1
            };

            var ninja2 = new Ninja
            {
                Name = "Leonardo",
                ServedInOniwaban = false,
                DateofBirth = new DateTime(1985, 03, 22),
                ClanId = 1
            };

            using (var context = new NinjaContext())
            {
                context.Database.Log = Console.WriteLine;
                context.Ninjas.AddRange(new List<Ninja> { ninja1, ninja2 });
                context.SaveChanges();
            }
        }

        private static void InsertNinja()
        {
            var ninja = new Ninja
            {
                Name = "Max",
                ServedInOniwaban = false,
                DateofBirth = new DateTime(2017, 02, 20),
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
