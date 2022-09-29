using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefening_models
{
    public class Winkelkar
    {
        public List<WinkelkarItem> WinkelkarItems { get; private set; } = new List<WinkelkarItem>();

        public void VoegWinkelkarItemToe(WinkelkarItem winkelkarItem)
        {
            if (WinkelkarItems.Contains(winkelkarItem))
            {
                WinkelkarItems.Find(x => x.Product.Code == winkelkarItem.Product.Code).Aantal += winkelkarItem.Aantal;
            }
            else
            {
                WinkelkarItems.Add(winkelkarItem);
            }
        }

        public decimal Korting(KortingHandler KortingMethod)
        {
            decimal som = Totaal();
            decimal korting = KortingMethod.Invoke(som);
            return korting;
        }

        public decimal Totaal()
        {
            decimal som = 0;
            WinkelkarItems.ForEach(x => som += x.Subtotaal());
            return som;
        }
    }
}