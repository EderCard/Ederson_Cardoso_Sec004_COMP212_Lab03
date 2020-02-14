using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ederson_Cardoso_Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice[] invoice =
            {
                new Invoice(87, "Electric Sander", 7, 57.98M),
                new Invoice(24, "Power Saw", 18, 99.99M),
                new Invoice(7, "sledge Hammerr", 11, 21.5M),
                new Invoice(77, "Hammer", 76, 11.99M),
                new Invoice(39, "Lawn Mower", 3, 79.5M),
                new Invoice(68, "Screw Driver", 106, 6.99M),
                new Invoice(56, "Jig Sawr", 21, 11.0M)
            };

            // Display all elements
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Original Invoice array:");
            Console.WriteLine("---------------------------------------");
            foreach (var element in invoice)
            {
                Console.WriteLine(element);
            }

            /*
             * a) Use LINQ to select from each Invoice the PartDescription and value of the Invoice(i.e.Quantity* Price). 
             *    Name the calculated column as InvoiceTotal.
             *    Order the results by invoice value in ascending order.
             *    [Hint: use let]
             */

            // Filter PartDescription and Value = Quantity * Price. 
            // Order the results by invoice value in ascending order.
            var descriptionValue =
               from item in invoice
               let InvoiceTotal = item.Quantity * item.Price
               orderby InvoiceTotal
               select new { item.PartDescription, InvoiceTotal };

            Console.WriteLine("\n---------------------------------------");
            Console.WriteLine("Part Description and Value of Invoice:");
            Console.WriteLine("---------------------------------------");
            foreach (var item in descriptionValue)
            {
                Console.WriteLine($"{item.PartDescription,-20} {item.InvoiceTotal,10:C}");
            }

            /*
             * b) Part description of the part who has highest quantity
             */
            var descriptionHighest =
               from item in invoice
               where item.Quantity == (from x in invoice select x.Quantity).Max()
               select new { item.PartDescription };

            Console.WriteLine("\n---------------------------------------");
            Console.WriteLine("Part description of highest quantity:");
            Console.WriteLine("---------------------------------------");
            foreach (var item in descriptionHighest)
            {
                Console.WriteLine($"{item.PartDescription,-20}");
            }

            /*
             * c) Average price of the parts.
             */
            var descAveragePrice =
                (from item in invoice select item.Price).Average();
            
            Console.WriteLine("\n---------------------------------------");
            Console.WriteLine("Average Price:");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Average Price: {descAveragePrice:C}");
            
            Console.ReadKey();
        
        } // end Main
    } // end Class
} // end namespace
