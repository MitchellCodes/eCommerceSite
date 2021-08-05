using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceSite.Models
{
    /// <summary>
    /// A salable product
    /// </summary>
    public class Product
    {
        [Key] // Make Primary Key in database
        public int ProductId { get; set; }

        /// <summary>
        /// The name of the product the consumer sees
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The retail price in US currency
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Category that the product falls under. Ex. Electronics, Furniture, etc.
        /// </summary>
        public string Category { get; set; }
    }
}
