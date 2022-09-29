using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening_models
{
    public class WinkelkarItem
    {
        public int Aantal { get; set; }
        public Product Product { get; set; }

        public override bool Equals(object obj)
        {
            return obj is WinkelkarItem item &&
                   EqualityComparer<Product>.Default.Equals(Product, item.Product);
        }

        public decimal Subtotaal()
        {
            return Product != null ? Aantal * Product.Prijs : 0;
        }

        public override string ToString()
        {
            if (Product != null)
            {
                return Aantal.ToString() + " X " + Product.ToString() + "   " + Subtotaal().ToString("c2");
            }
            return "";
        }
    }
}