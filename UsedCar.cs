using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bounus18
{
    class UsedCar : Car
    {
        protected double mialage;

        public double Mialage
        {
            set { mialage = value; }
            get { return mialage; }


        }
        //new constractor for the subclass
        /*we can use the constractor from the parent class by using base:with the it's input*/
        public UsedCar(string carmake, string carmodel, int caryear, double carprice, double carmialage)
           : base(carmake, carmodel, caryear, carprice)
        {
            Mialage = carmialage;
        }

            public override   string ToString()
        {
            return ($"\t{ Make}\t{ Model}\t{ Year}\t{ Price}\tUsed\t{mialage}Miles");
        }


    }



    }

