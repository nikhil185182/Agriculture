using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Human
{
    public abstract void designation();
    public void Info()
    {
        Console.WriteLine("I'm a Human");
    }
}

interface BasicActions
{
    void Eat();
    void Sleep();
}



class Farmer : Human,BasicActions
{
    public override void designation()
    {
        Console.WriteLine("Work is : Farming crops,plants");
    }

    public void Eat()
    {
        Console.WriteLine("Eats : Rice,Vegetables");
    }

    public void Sleep()
    {
        Console.WriteLine("Sleep : 6 hrs per day,wakes up early");
    }

}


namespace Organisation
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Farmer f = new Farmer();
            f.Info();
            f.designation();
            f.Eat();
            f.Sleep();
            
            //publisher
            var farming = new Farming();

            //subscribers
            var sell = new SellCrop();
            var pay = new PayLoan();

            farming.FarmingCompleted += sell.onFarmingCompleted;
            farming.FarmingCompleted += pay.onFarmingCompleted;

          

            farming.doFarming(f);

            Console.ReadKey();
        }
    }
}
