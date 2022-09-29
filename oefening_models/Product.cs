using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening_models
{
    public class Product
    {
        public int Code { get; set; }
        public string Omschrijving { get; set; }
        public decimal Prijs { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Product product &&
                   Code == product.Code;
        }

        public override string ToString()
        {
            return $"{Omschrijving} - {Prijs.ToString("c2")}";
        }
    }
}