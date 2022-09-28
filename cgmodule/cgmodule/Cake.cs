using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace CakeApp
{
    class Program
    {
        static void Main2(string[] args)
        {
            ICake cup = new CupCake();
            var res = cup.getPrice("Vanilla", 2, 0.5);
            Console.WriteLine(res);
        }
    }
    interface ICake
    {
        public double getPrice(string flavour, int toppings, double sizeinKg);
    }
    public class CupCake : ICake
    {

        public double getPrice(string flavour, int toppings, double sizeinKg)
        {
            double price = 0;
            if (flavour == "Vanilla")
            {
                return(sizeinKg * (toppings * 15 + (100)));
            }
            else
            {
                if (flavour == "Chocalate")
                {
                    return(sizeinKg * (toppings * 15 + (150)));
                }
                return price;
            }
        }

    }
    public class PinataCake : ICake
    {
      

        public double getPrice(string flavour, int toppings, double sizeinKg)
        {
            double price = 0;
            if (flavour == "Vanilla")
            {
                return(sizeinKg * (toppings * 40) + 250 + (100));
            }
            else
            {
                if (flavour == "Chocalate")
                {
                    return (sizeinKg * (toppings * 40) + 350 + (100));
                }
                return price;
            }
        }

      
    }
}

