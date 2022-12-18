using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organisation
{
    internal class SellCrop
    {
        public void onFarmingCompleted(object source,EventArgs args)
        {
            Console.WriteLine("Crop sold and got Money");
        }
    }
}
