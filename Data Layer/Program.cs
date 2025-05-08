using Microsoft.EntityFrameworkCore;
using NTierExample.Data.Context;
using System.Text;
using NTierExample.Data.Types;

namespace NTierExample.Data.Startup
{
    class Program
    {
        static void Main(string[] args)
        {
            InsertData();
            PrintData();
        }

        public static void InsertData()
        {
            using (var context = new LibraryContext())
            {
                // Creates the database if not exists
                context.Database.EnsureCreated();

                // Adds a barista
                var barista = new Barista
                {
                    id = 1,
                    round = 1,
                    currentDmg = 2,
                    currentHealth = 3
                };
                context.Barista.Add(barista);

                // Saves changes
                context.SaveChanges();
            }
        }

        public static void PrintData()
        {
            // Gets and prints all baristas
            using (var context = new LibraryContext())
            {
                var baristas = context.Barista;
                foreach (var barista in baristas)
                {
                    var data = new StringBuilder();
                    data.AppendLine($"Id: {barista.id}");
                    data.AppendLine($"Round: {barista.round}");
                    data.AppendLine($"Current Health: {barista.currentHealth}");
                    data.AppendLine($"Current Damage: {barista.currentDmg}");
                    Console.WriteLine(data.ToString());
                }
            }
        }
    }
}