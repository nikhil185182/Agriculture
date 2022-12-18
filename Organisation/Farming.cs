using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Organisation
{
    internal class Farming
    {
        //1.Define a deligate
        public delegate void FarmingCompletedHandler(object source, EventArgs args);
        //2. define a event based on delegate
        public event FarmingCompletedHandler FarmingCompleted;
        
        public void doFarming(Farmer f)
        {
            Console.WriteLine("Started Farming");
            Thread.Sleep(3000);
            Console.WriteLine("Farming Completed");
            Thread.Sleep(3000);

            //3. Raise event -- by a method resposible for that
            onFarmingCompleted();

        }
        //event publisher methods shoud be public,virtual,void
        public virtual void onFarmingCompleted()
        {
            if (FarmingCompleted != null)
                FarmingCompleted(this, EventArgs.Empty);
        }

    }
}
