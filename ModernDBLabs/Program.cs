using BasicRequestLab.Models;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace BasicRequestLab
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await using var context = new UnivModernDBContext();

            var vendor = new Vendor()
            {
                City = "Kyiv",
                Sname = "Mark",
                Comm = .15m
            };

            try
            {
                await context.Vendors.AddAsync(vendor);
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            var vendors = context.Vendors.Select(p => p);

            Console.WriteLine("Vendor ID\tVendor Name\tVendor City\tVendor commission");
            foreach (var v in vendors)
            {
                Console.WriteLine($"{v.Cnum}\t{v.Sname}\t{v.City}\t{v.Comm}");
            }

            Console.ReadKey();
        }
    }
}
