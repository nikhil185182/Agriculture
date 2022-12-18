using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organisation
{
    internal class PayLoan
    {
        public void onFarmingCompleted(object source,EventArgs args)
        {
            Console.WriteLine("Loan is Cleared");
        }
    }
}
