using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ederson_Cardoso_Exercise02
{
    public class Invoice
    {
        // Properties
        public int PartNumber { get; set; }
        public string PartDescription { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        // Constructor
        public Invoice(int partNumber, string partDescription, int quantity, decimal price)
        {
            this.PartNumber = partNumber;
            this.PartDescription = partDescription;
            this.Quantity = quantity;
            this.Price = price;
        }

        /// <summary>
        /// This method override the toString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format($"{PartNumber,2} {PartDescription,-15} {Quantity,5} {Price,6:C}");
        } 

    } // end Class
} // end namespace
