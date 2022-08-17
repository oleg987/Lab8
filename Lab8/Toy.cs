using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Toy
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Toy(string title, decimal price, int quantity)
        {
            Title = title;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"{Title} -> {Price} $";
        }
    }
}
