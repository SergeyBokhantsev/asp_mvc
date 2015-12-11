using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_e3.Models
{
    public interface IValueCalculator
    {
        decimal ValueProducts(IEnumerable<Product> products);
    }

    public class LinqValueCalculator : IValueCalculator
    {
        public decimal DiscountSize { get; set; }

        public decimal ValueProducts(IEnumerable<Product> products)
        {
            return products.Sum(p => p.Price) - DiscountSize;
        }
    }
}